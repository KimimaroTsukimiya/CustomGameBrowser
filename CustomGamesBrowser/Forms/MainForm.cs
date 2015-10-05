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
		public CustomGameBrowser cgb;
        public Dictionary<string, CustomGame> installedCustomGames;
		public Random random = new Random();

		public MainForm(CustomGameBrowser cgb) {
			InitializeComponent();
			this.cgb = cgb;
			installedCustomGames = cgb.installedCustomGames;

			versionLink.Text = "v" + cgb.version;

			this.Shown += (s, e) => {
				initMainPanel();
			};

			this.FormClosed += (s, e) => {
				cgb.serializeSettings();
			};


			if (!Directory.Exists("Thumbnails")) {
				Directory.CreateDirectory("Thumbnails");
			}

			var sizeCalc = Util.CreateTimer(200, (timer) => {
				double size = 0;
				foreach (var kv in installedCustomGames) {
					var cg = kv.Value;
					size += cg.size;
				}
				totalSizeLabel.Text = "Total size: " + Math.Round(size, 1).ToString() + " MB";
			});
		}

		private void initMainPanel() {
			totalSizeLabel.Text = "Total size: 0 MB";
			int count = 1, tileX = 4, tileY = 4;
			foreach (var kv in cgb.installedCustomGames) {
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
			//mainPanel.Controls.Add(mt); // is this needed when the parent is already set?
			mt.Location = location;
			mt.ContextMenuStrip = metroContextMenu1;
			mt.Style = (MetroColorStyle)random.Next(4, 14);
			mt.Theme = MetroThemeStyle.Light;
			mt.Size = new Size(128, 116);
			mt.Click += (s, e) => {
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
			Process.Start("https://github.com/stephenfournier/CustomGameBrowser/releases/tag/v" + cgb.version);
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
				cgb.retrieveInstalledCustomGames();
				cgb.deserializeSettings();
				initMainPanel();
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
	}
}
