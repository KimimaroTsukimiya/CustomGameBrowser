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
		public string installedCustomsDir = "";
		public string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		public Dictionary<string, CustomGame> installedCustomGames = new Dictionary<string, CustomGame>();
		public Random random = new Random();
		public Updater updater;

		public MainForm() {
			InitializeComponent();

			// change version so it matches our specs
			version = version.Substring(0, version.LastIndexOf('.'));
			versionLink.Text = "v" + version;

			setupHooks();

			if (!Directory.Exists("Thumbnails")) {
				Directory.CreateDirectory("Thumbnails");
			}

			// check for updates
			updater = new Updater(this);

			// get the dota dir
			retrieveDotaDir();

			installedCustomsDir = dotaDir.Substring(0, dotaDir.IndexOf("steamapps") + "steamapps".Length);
			installedCustomsDir = Path.Combine(installedCustomsDir, "workshop", "content", "570");

			var sizeCalc = Util.CreateTimer(200, (timer) => {
				double size = 0;
				foreach (var kv in installedCustomGames) {
					var cg = kv.Value;
					size += cg.size;
				}
				totalSizeLabel.Text = "Total size: " + Math.Round(size, 1).ToString() + " MB";
			});
		}

		private void setupHooks() {
			this.Shown += (s, e) => {
				retrieveInstalledCustomGames();
				deserializeSettings();
				initMainPanel();
			};

			this.FormClosed += (s, e) => {
				serializeSettings();
			};
		}

		public void retrieveInstalledCustomGames() {
			installedCustomGames.Clear();
			var customGameDirs = Directory.GetDirectories(installedCustomsDir);
			foreach (var customGameDir in customGameDirs) {
				var customGame = new CustomGame(this, customGameDir);

				if (customGame.vpk == null) {
					continue;
				}

				installedCustomGames.Add(customGame.workshopID, customGame);
			}
		}

		private void retrieveDotaDir() {
			// start process of retrieving dota dir
			dotaDir = Settings.Default.DotaDir;

			if (dotaDir == "") {
				// user opened this application for the first time ever.
				// try to auto-get the dir
				dotaDir = Util.GetDotaDir();

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

						Application.Exit();
						return;
					}
					string p = fbd.SelectedPath;
					dotaDir = p;
				}
			}

			Settings.Default.DotaDir = dotaDir;
			Settings.Default.Save();
		}

		private void initMainPanel() {
			totalSizeLabel.Text = "Total size: 0 MB";
			int count = 1, tileX = 4, tileY = 4;
			foreach (var kv in installedCustomGames) {
				var customGame = kv.Value;
				MetroTile mt;
				MetroProgressSpinner ps;
				CreateMainPanelTile(new Point(tileX, tileY), out mt, out ps);
				customGame.tile = mt;
				customGame.spinner = ps;
				customGame.count = count;
				htmlToolTip1.SetToolTip(mt, "Left-click to open " + customGame.name + "'s Workshop page. Right-click for more options.<p>" + "Last updated: " + customGame.last_updated_time + "</p>");
				customGame.displaySize();
				customGame.initTile();

				// Prepare for next iteration
				tileX += 132;
				if (count % 5 == 0) {
					// new row
					tileX = 4;
					tileY += 120;
				}
				count++;
			}
		}

		private void CreateMainPanelTile(Point location, out MetroTile out_mt, out MetroProgressSpinner out_ps) {
			var mt = new MetroTile();
			mt.Parent = mainPanel;
			mt.Location = location;
			mt.ContextMenuStrip = metroContextMenu1;
			mt.Style = (MetroColorStyle)random.Next(4, 14);
			mt.Theme = MetroThemeStyle.Light;
			mt.Size = new Size(128, 116);
			mt.Click += (s, e) => {
				fixButton();
				foreach (var kv2 in installedCustomGames) {
					var cg = kv2.Value;
					if (mt == cg.tile) {
						Process.Start(cg.url);
						break;
					}
				}
			};

			// Setup the spinner
			MetroProgressSpinner ps = new MetroProgressSpinner();
			ps.Parent = mt;
			ps.Visible = false;
			ps.Size = new Size(38, 38);
			ps.Location = new Point(44, 38);
			ps.Style = mt.Style;
			ps.Value = 70;

			out_mt = mt;
			out_ps = ps;
		}

		public void fixButton() {
			dummyBtn.Select();
		}


		private void openVPKToolStripMenuItem_Click(object sender, EventArgs e) {
			var tile = (MetroTile)Util.GetCallingControl(sender, new MetroTile());
			foreach (var kv in installedCustomGames) {
				var cg = kv.Value;
				if (tile == cg.tile) {
					Process.Start(cg.vpk);
					break;
				}
			}
		}

		private void versionLink_Click(object sender, EventArgs e) {
			Process.Start("https://github.com/stephenfournier/CustomGameBrowser/releases/tag/v" + version);
		}

		private void refreshBtn_Click(object sender, EventArgs e) {
			//panel1.AutoScrollPosition = new Point(0, 0);
			mainPanel.VerticalScroll.Value = 0;

			foreach (var kv in installedCustomGames) {
				var cg = kv.Value;
				cg.tile.Dispose();
				cg.spinner.Dispose();
			}

			Util.CreateTimer(100, (timer) => {
				timer.Stop();
				this.OnShown(null);
			});
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
			var tile = (MetroTile)Util.GetCallingControl(sender, new MetroTile());
			CustomGame customGame = null;
			foreach (var kv in installedCustomGames) {
				var cg = kv.Value;
				if (tile == cg.tile) {
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

		private void changelogToolStripMenuItem_Click(object sender, EventArgs e) {
			var tile = (MetroTile)Util.GetCallingControl(sender, new MetroTile());
			foreach (var kv in installedCustomGames) {
				var cg = kv.Value;
				if (tile == cg.tile) {
					Process.Start(cg.changelogUrl);
					break;
				}
			}
		}

		#region serializing functions

		public void serializeSettings() {
			var root = new KeyValue("InstalledAddons");
			foreach (var kv in installedCustomGames) {
				var cg = kv.Value;
				cg.serializeSettings();
				root.AddChild(cg.addonKV);
			}
			Settings.Default.InstalledAddonsKV = root.ToString();

			Settings.Default.Save();
		}

		public void deserializeSettings() {
			var installedAddonsKV = Settings.Default.InstalledAddonsKV;
			if (installedAddonsKV == null || installedAddonsKV == "") {
				return;
			}
			var root = KVParser.KV1.Parse(installedAddonsKV);
			foreach (var kv in root.Children) {
				var workshopID = kv.Key;
				if (installedCustomGames.ContainsKey(workshopID)) {
					installedCustomGames[workshopID].deserializeSettings(kv);
				}
			}
		}
		#endregion

	}
}
