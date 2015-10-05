using CustomGamesBrowser.Properties;
using KVLib;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CustomGamesBrowser {
	public class CustomGameBrowser {
		public string dotaDir = "";
		public string installedCustomsDir = "";
		public string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		public Dictionary<string, CustomGame> installedCustomGames = new Dictionary<string, CustomGame>();

		// forms
		public MainForm mainForm;
		public Updater updater;

		public CustomGameBrowser() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			mainForm = new MainForm(this);

			// change version so it matches our specs
			version = version.Substring(0, version.LastIndexOf('.'));

			// check for updates
			updater = new Updater(this);

			// get the dota dir
			retrieveDotaDir();

			//installedCustomsDir
			installedCustomsDir = dotaDir.Substring(0, dotaDir.IndexOf("steamapps") + "steamapps".Length);
			installedCustomsDir = Path.Combine(installedCustomsDir, "workshop", "content", "570");

			retrieveInstalledCustomGames();
			deserializeSettings();

			Application.Run(mainForm);
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
					dr = MetroMessageBox.Show(mainForm,
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
						MetroMessageBox.Show(mainForm, "No folder selected. Exiting.",
							"Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);

						Environment.Exit(0);
						return;
					}
					string p = fbd.SelectedPath;
					dotaDir = p;
				}
			}
			Settings.Default.Save();
		}

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

	}
}