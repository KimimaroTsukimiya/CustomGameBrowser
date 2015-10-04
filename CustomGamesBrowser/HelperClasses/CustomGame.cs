using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using KVLib;
using MetroFramework;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace CustomGamesBrowser {
	public class CustomGame {
		public string installationDir;
		public string workshopID;
		public string url;
		public Image workshopImage;
		public string vpk;
		public string publish_data;
		public MetroTile tile;
		public MetroProgressSpinner spinner;
		public int page;
		public string name;
		public string last_updated_time = "Not available";
		public string changelogUrl;
		public MetroColorStyle defaultStyle;
		public string fileFriendlyName;
		public string workshopImagePath;
		public bool retrievingImage;
		public bool doneRetrieving;
		public MainForm mainForm;
		public int count;
		public double size;

		// settings
		public int WorkshopImgSizeOnWeb;
		public KeyValue addonKV;

		public CustomGame(MainForm mainForm, string installationDir) {
			this.mainForm = mainForm;
			this.installationDir = installationDir;
			workshopID = installationDir.Substring(installationDir.LastIndexOf('\\')+1);
			url = "http://steamcommunity.com/sharedfiles/filedetails/?id=" + workshopID;
			workshopImagePath = Path.Combine("Thumbnails", workshopID + ".jpg");
			changelogUrl = "http://steamcommunity.com/sharedfiles/filedetails/changelog/" + workshopID;

			var gameFiles = Directory.GetFiles(installationDir);
			foreach (var file in gameFiles) {
				if (file.EndsWith(".vpk")) {
					vpk = file;
				} else if (file.EndsWith("publish_data.txt")) {
					publish_data = file;
					getPublishDataInfo();
				}
			}
		}

		private void getPublishDataInfo() {
			var txt = File.ReadAllText(publish_data);
			var kv = KVParser.KV1.Parse(txt);
			foreach (var kv2 in kv.Children) {
				if (kv2.Key == "title") {
					name = kv2.GetString();
					fileFriendlyName = name.Replace(' ', '_');
				} else if (kv2.Key == "publish_time_readable") {
					last_updated_time = kv2.GetString();
				}
			}
		}

		public void retrieveWorkshopImage() {
			if (File.Exists(workshopImagePath) && new FileInfo(workshopImagePath).Length > 50) {
				workshopImage = (Image)new Bitmap(Image.FromFile(workshopImagePath), tile.Size);
				initTile();
			}

			BackgroundWorker bw = new BackgroundWorker();
			retrievingImage = true;
			var source = "";
			bw.DoWork += (s, e) => {
				using (WebClient wc = new WebClient()) {
					var data = wc.DownloadData(url);
					source = Encoding.ASCII.GetString(data);
					var signal = "<link rel=\"image_src\" href=\"";
					var lines = source.Split('\n');
					foreach (var line in lines) {
						if (line.StartsWith(signal)) {
							var imgLink = line.Substring(signal.Length);
							imgLink = imgLink.Substring(0, imgLink.IndexOf("/?") + 1);

							long totalBytes = 0;
							using (var stream = wc.OpenRead(imgLink)) {
								totalBytes = Convert.ToInt64(wc.ResponseHeaders["Content-Length"]);
							}

							bool download = false;
							if (File.Exists(workshopImagePath)) {
								if (totalBytes != WorkshopImgSizeOnWeb) {
									File.Delete(workshopImagePath);
									download = true;
								} else {
									//Debug.WriteLine("Same image. Not downloading image for " + name);
								}
							} else {
								download = true;
							}
							if (download) {
								var byteArr = wc.DownloadData(imgLink);
								using (MemoryStream ms = new MemoryStream(byteArr)) {
									var im = Image.FromStream(ms);
									im = new Bitmap(im, new Size(128, 128));
									im.Save(workshopImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
									WorkshopImgSizeOnWeb = byteArr.Length;
									//Debug.WriteLine("Saved image for: " + workshopImagePath);
								}
							}
							break;
						}
					}
				}
			};
			bw.RunWorkerCompleted += (s, e) => {
				doneRetrieving = true;
				retrievingImage = false;
				spinner.Visible = false;

				if (File.Exists(workshopImagePath)) {
					if (!(new FileInfo(workshopImagePath).Length > 50)) {
						File.Delete(workshopImagePath);
					} else {
						workshopImage = new Bitmap(Image.FromFile(workshopImagePath), tile.Size);
						initTile();
					}
				}
			};
			bw.RunWorkerAsync();
		}

		internal void deserializeSettings(KeyValue root) {
			foreach (var kv in root.Children) {
				if (kv.Key == "WorkshopImgSizeOnWeb") {
					WorkshopImgSizeOnWeb = kv.GetInt();
                }
			}
		}
		internal void serializeSettings() {
			addonKV = new KeyValue(workshopID);
			if (WorkshopImgSizeOnWeb != 0) {
				addonKV.AddChild(new KeyValue("WorkshopImgSizeOnWeb").Set(WorkshopImgSizeOnWeb));
			}
        }

		internal void initTile() {
			tile.Text = name;
			tile.Visible = true;

			if (workshopImage != null) {
				// set image
				tile.UseTileImage = true;
				tile.TileImage = workshopImage;
				//Debug.WriteLine(name = " using own image now.");
			} else {
				tile.UseTileImage = false;
				tile.Style = defaultStyle;
				if (retrievingImage) {
					spinner.Visible = true;
				}
			}

			Timer timer = new Timer();
			timer.Interval = 100;
			timer.Tick += (s, e) => {
				timer.Stop();
				tile.Refresh();
			};
			timer.Start();
		}

		public void displaySize() {
			var sizeWorker = new BackgroundWorker();
			string sizeStr = "";
			sizeWorker.DoWork += (s, e) => {
				var size = Util.GetDirectorySize(installationDir) / 1024.0 / 1024.0;
				size = Math.Round(size, 1);
				this.size = size;
				sizeStr = size.ToString();
				//Debug.WriteLine("size of " + name + ": " + size);
			};

			sizeWorker.RunWorkerCompleted += (s, e) => {
				mainForm.htmlToolTip1.SetToolTip(tile, "(<b>" + sizeStr + " MB</b>). Left-click to open " + name + "'s Workshop page. Right-click for more options.<p>" + "Last updated: " + last_updated_time + "</p>");
			};
			sizeWorker.RunWorkerAsync();
		}
	}
}
