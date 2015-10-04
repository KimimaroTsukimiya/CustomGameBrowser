using CustomGamesBrowser.Properties;
using KVLib;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CustomGamesBrowser {
	public partial class MainForm : MetroForm {
		public string dotaDir = "";
		public string customGamesDir = "";
		public Dictionary<string, CustomGame> customGames = new Dictionary<string, CustomGame>();
		public Dictionary<string, string> installedAddonSettings = new Dictionary<string, string>();
		public static int NUM_TILES = 20;
		public int customGameCount;
		public int totalPages = 1;
		public int currPage = 1;
		public string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		Updater updater;

		public MainForm() {

			InitializeComponent();

			// change version so it matches our specs
			version = version.Substring(0, version.LastIndexOf('.'));
			versionLink.Text = "v" + version;

			this.FormClosed += (s, e) => {
				serializeSettings();
			};

			//metroToolTip1.theme
			//htmlToolTip1.

			// check for updates
			updater = new Updater(this);
			updater.checkForUpdates();

			// get the dota dir
			retrieveDotaDir();

			// *** at this point assume valid dota dir. ***

			// save the dota dir
			Settings.Default.DotaDir = dotaDir;

			Debug.WriteLine("Directory: " + dotaDir);

			customGamesDir = dotaDir.Substring(0, dotaDir.IndexOf("steamapps") + 9);
			customGamesDir = Path.Combine(customGamesDir, "workshop", "content", "570");

			if (!Directory.Exists("Thumbnails")) {
				Directory.CreateDirectory("Thumbnails");
			}

			Timer timer = new Timer();
			timer.Interval = 100;
			timer.Tick += (s, e) => {
				timer.Stop();
				retrieveCustomGames();
				deserializeSettings();
				initCustomGameBrowser();
			};
			timer.Start();
		}

		private void serializeSettings() {
			var root = new KeyValue("InstalledAddons");
			foreach (var kv in customGames) {
				var cg = kv.Value;
				cg.serializeSettings();
				root.AddChild(cg.addonKV);
			}
			Settings.Default.InstalledAddonsKV = root.ToString();

			Settings.Default.Save();
		}

		private void retrieveCustomGames() {
			customGames.Clear();
			var customGameDirs = Directory.GetDirectories(customGamesDir);
			foreach (var customGameDir in customGameDirs) {
				var customGame = new CustomGame(this, customGameDir);

				if (customGame.vpk == null) {
					continue;
				}

				customGames.Add(customGame.workshopID, customGame);
			}
		}

		private void deserializeSettings() {
			var installedAddonsKV = Settings.Default.InstalledAddonsKV;
			if (installedAddonsKV == null || installedAddonsKV == "") {
				return;
			}
			var root = KVParser.KV1.Parse(installedAddonsKV);
			foreach (var kv in root.Children) {
				if (customGames.ContainsKey(kv.Key)) {
					customGames[kv.Key].deserializeSettings(kv);
				}
			}

		}

		private void initCustomGameBrowser() {
			Random random = new Random();
			HashSet<MetroColorStyle> usedStyles = new HashSet<MetroColorStyle>();
			int count = 1;
			int mtX = 4;
			int mtY = 4;
			foreach (var kv in customGames) {
				var customGame = kv.Value;
				// Setup the tile
				MetroTile mt = new MetroTile();
				mt.Parent = panel1;
				mt.Size = new Size(128, 116);
				mt.Location = new Point(mtX, mtY);
				mt.ContextMenuStrip = metroContextMenu1;

				// grab a random style
				if (usedStyles.Count == 11) {
					usedStyles.Clear();
				}
				var style = (MetroColorStyle)random.Next(3, 14);
				while (usedStyles.Contains(style)) {
					style = (MetroColorStyle)random.Next(3, 14);
				}
				usedStyles.Add(style);
				mt.Style = style;

				mt.Visible = false;
				mt.Theme = MetroThemeStyle.Light;
				mt.Click += (s, e) => {
					foreach (var kv2 in customGames) {
						var cg = kv2.Value;
						if (mt == cg.tile) {
							Process.Start(cg.url);
							break;
						}
					}
				};

				// setup the spinner
				MetroProgressSpinner ps = new MetroProgressSpinner();
				ps.Parent = mt;
				ps.Size = new Size(38, 38);
				ps.Style = mt.Style;
				ps.Value = 70;
				ps.Location = new Point(44, 38);
				ps.Visible = false;

				mtX += 132;

				if (count % 5 == 0) {
					// new row
					mtX = 4;
					mtY += 120;
				}

				panel1.Controls.Add(mt);

				var tile = mt;
				var spinner = ps;
				customGame.defaultStyle = tile.Style;

				customGame.tile = tile;
				customGame.spinner = spinner;
				customGame.page = totalPages;
				try {
					customGame.retrieveWorkshopImage();
				} catch (Exception ex) {
					customGame.initTile();
				}
				count++;
			}

			changePage(1);
		}

		public void fixButton() {
			dummyBtn.Select();
		}

		private void retrieveDotaDir() {
			// start process of retrieving dota dir
			dotaDir = Settings.Default.DotaDir;

			if (Settings.Default.DotaDir == "") {
				// this is first run of application

				// try to auto-get the dir
				dotaDir = Util.getDotaDir();

				DialogResult dr = DialogResult.No;
				if (dotaDir != "") {
					// first run of modkit on this computer.
					dr = MetroMessageBox.Show(this,
						"Dota directory has been set to: " + dotaDir + ". Is this correct?",
						"Dota Directory",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Information);
				}

				if (dr == DialogResult.No) {
					FolderBrowserDialog fbd = new FolderBrowserDialog();
					fbd.Description = "Dota 2 directory (i.e. 'dota 2 beta')";
					var dr2 = fbd.ShowDialog();

					if (dr2 != DialogResult.OK) {
						MetroMessageBox.Show(this, "No folder selected. Exiting.",
							"Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);

						Environment.Exit(0);
					}
					string p = fbd.SelectedPath;
					dotaDir = p;
				} else {
					Settings.Default.Save();
				}
			}

			/* ModKit must ran in the same drive as the dota dir.
			if (!Util.hasSameDrives(Environment.CurrentDirectory, dotaDir)) {
				MetroMessageBox.Show(this, "Dota 2 ModKit must be ran from the same drive as Dota 2 or else errors " +
					"will occur. Please move Dota 2 ModKit to the '" + dotaDir[0] + "' Drive and create a shortcut to it. Exiting.",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				Environment.Exit(0);
			}*/
		}

		private void changePage(int currPage) {
			int count = 1;
			foreach (var kv in customGames) {
				var cg = kv.Value;
				if (cg.page == currPage) {
					cg.count = count;
					cg.initTile();
					count++;
				}

			}
			for (int i = count; i <= NUM_TILES; i++) {
				var tile = (MetroTile)panel1.Controls["mt" + i];
				var spinner = (MetroProgressSpinner)tile.Controls["ps" + i];
				tile.Visible = false;
				spinner.Visible = false;
			}

		}

		private void openVPKToolStripMenuItem_Click(object sender, EventArgs e) {
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			var owner = (ContextMenuStrip)item.Owner;
			MetroTile tile = (MetroTile)(owner.SourceControl);
			foreach (var kv in customGames) {
				var cg = kv.Value;
				if (cg.page == currPage && tile == cg.tile) {
					Process.Start(cg.vpk);
					break;
				}
			}
		}

		private void versionLink_Click(object sender, EventArgs e) {
			Process.Start("https://github.com/stephenfournier/CustomGameBrowser/releases/tag/v" + version);
		}

		private void refreshBtn_Click(object sender, EventArgs e) {
			panel1.AutoScrollPosition = new Point(0, 0);
			//panel1.AutoScrollPosition.
			foreach (var kv in customGames) {
				var cg = kv.Value;
				cg.tile.Dispose();
				cg.spinner.Dispose();
			}
			retrieveCustomGames();
			deserializeSettings();
			initCustomGameBrowser();
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			var owner = (ContextMenuStrip)item.Owner;
			MetroTile tile = (MetroTile)(owner.SourceControl);
			CustomGame customGame = null;
			foreach (var kv in customGames) {
				var cg = kv.Value;
				if (cg.page == currPage && tile == cg.tile) {
					customGame = cg;
					break;
				}
			}
			var dr = MetroMessageBox.Show(this,
				"Are you sure you want to delete " + customGame.name + " from this computer?",
				"Confirmation",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
			if (dr != DialogResult.Yes) {
				return;
			}
			if (Directory.Exists(customGame.installationDir)) {
				Directory.Delete(customGame.installationDir, true);
			}
			refreshBtn_Click(null, null);
		}
	}
}
