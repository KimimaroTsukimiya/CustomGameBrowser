using CustomGamesBrowser.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CustomGamesBrowser {
	public class Updater {
		CustomGameBrowser cgb;
		public string version;
		public string url = "";
		public string newVers = "";
		public bool newVersFound = false;
		public string releases_page_source;

		public Updater(CustomGameBrowser cgb) {
			this.cgb = cgb;
			version = cgb.version;

			checkForUpdates();
		}

		public void checkForUpdates() {
			// Check for settings updates.
			if (Settings.Default.UpdateRequired) {
				Settings.Default.Upgrade();
				Settings.Default.UpdateRequired = false;
				Settings.Default.Save();
			}

			var updatesWorker = new BackgroundWorker();
			updatesWorker.DoWork += (s, e) => {
				// use these to test version updater.
				//newVers = "1.3.2";
				//url = "https://github.com/stephenfournier/Dota-2-ModKit/releases/download/v1.3.2/D2ModKit.zip";

				// remember to keep the version naming consistent!
				//  you can go from 1.3.4.4 to 1.3.5.0, OR 1.3.4.0 to 1.3.5.0

				int count = 1;
				int j = 0;
				while (true) {
					newVers = Util.IncrementVers(version, count + j);
					url = "https://github.com/stephenfournier/CustomGameBrowser/releases/download/v";
					url += newVers + "/CustomGameBrowser.zip";
					WebClient wc = new WebClient();

					try {
						byte[] responseBytes = wc.DownloadData("https://github.com/stephenfournier/CustomGameBrowser/releases/tag/v" + newVers);
						releases_page_source = Encoding.ASCII.GetString(responseBytes);
					} catch (Exception) {
						if (j < 10) {
							j++;
							continue;
						}
						break;
					}

					newVersFound = true;
					count += j + 1;
					j = 0;
				}
				newVers = Util.IncrementVers(version, count - 1);
				url = "https://github.com/stephenfournier/CustomGameBrowser/releases/download/v";
				url += newVers + "/CustomGameBrowser.zip";
			};

			updatesWorker.RunWorkerCompleted += (s, e) => {
				if (!newVersFound) {
					Debug.WriteLine("No new vers available.");
					return;
				}

				UpdateInfoForm uif = new UpdateInfoForm(cgb, this);
				uif.Parent = cgb.mainForm;
				uif.ShowDialog();
			};

			updatesWorker.RunWorkerAsync();
		}
	}
}
