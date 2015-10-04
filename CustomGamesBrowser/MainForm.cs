using CustomGamesBrowser.Properties;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CustomGamesBrowser {
	public partial class MainForm : MetroForm {
		public string dotaDir = "";
		public string customGamesDir = "";
		public Dictionary<string, CustomGame> customGames = new Dictionary<string, CustomGame>();
		public static int NUM_TILES = 20;
		public int customGameCount;
		public int totalPages = 1;
		public int currPage = 1;
		public string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		Updater updater;

		public MainForm() {

			InitializeComponent();

			this.FormClosed += (s, e) => {
				Settings.Default.Save();
			};

			versionLink.Text = "v" + version;

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
				initBrowser();
			};
			timer.Start();
		}

		private void initBrowser() {

			var customGameDirs = Directory.GetDirectories(customGamesDir);
			int count = 1;
			foreach (var customGameDir in customGameDirs) {
				var customGame = new CustomGame(this, customGameDir);

				if (customGame.vpk == null) {
					continue;
				}

				if (count > NUM_TILES) {
					totalPages++;
					count = 1;
				}
					
				var tile = (MetroTile)Controls["mt" + count];
				var spinner = (MetroProgressSpinner)tile.Controls["ps" + count];
				customGame.defaultStyle = tile.Style;

				customGame.tile = tile;
				customGame.spinner = spinner;
				customGame.page = totalPages;
				customGames.Add(customGame.workshopID, customGame);
				customGame.retrieveWorkshopImage();
				Debug.WriteLine("Initializing: " + customGame.name);
				count++;
			}

			if (totalPages > 1) {
				nextBtn.Visible = true;
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

		private void nextBtn_Click(object sender, EventArgs e) {
			fixButton();

			currPage++;
			if (currPage == totalPages) {
				nextBtn.Visible = false;
			}
			if (currPage == 2) {
				backBtn.Visible = true;
			}
			changePage(currPage);
		}

		private void backBtn_Click(object sender, EventArgs e) {
			fixButton();

			currPage--;
			if (currPage == 1) {
				backBtn.Visible = false;
			}
			if (currPage == totalPages-1) {
				nextBtn.Visible = true;
			}
			changePage(currPage);
		}

		private void changePage(int currPage) {
			//for

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
				var tile = (MetroTile)Controls["mt" + i];
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

		private void onTileClick(object sender, EventArgs e) {
			var tile = (MetroTile)sender;
			foreach (var kv in customGames) {
				var cg = kv.Value;
				if (cg.page == currPage && tile == cg.tile) {
					Process.Start(cg.url);
					break;
				}
			}
		}

		private void versionLink_Click(object sender, EventArgs e) {
			Process.Start("https://github.com/stephenfournier/CustomGameBrowser/releases/tag/v" + version);
		}
	}
}
