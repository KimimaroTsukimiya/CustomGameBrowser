using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomGamesBrowser {
	public static class Util {
		public static string logPath = Path.Combine("debug_log.txt");

		public static void Log(string text) {
			try {
				// if log file is over xxx KB, delete.
				if (File.Exists(logPath) && new FileInfo(logPath).Length > 1024 * 400) {
					File.Delete(logPath);
				}

				if (!File.Exists(logPath)) {
					File.Create(logPath).Close();
				}

				StringBuilder logText = new StringBuilder(File.ReadAllText(logPath));
				if (logText.Length == 0) {
					logText.AppendLine("REPORT THIS TO https://github.com/stephenfournier/CustomGameBrowser/issues/new IF CRASHES OCCUR.\n");
				}

				logText.AppendLine("\n\nNEW ENTRY: " + DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString());
				logText.AppendLine(text);

				File.WriteAllText(logPath, logText.ToString());
			} catch (Exception) { }
		}

		internal static void LogException(Exception ex) {
			StringBuilder txt = new StringBuilder();
			txt.AppendLine("ex.toString(): " + ex.ToString());
			// toString() includes the Message and StackTrace.
			//txt.AppendLine("Message: " + ex.Message);
			//txt.AppendLine("StackTrace: " + ex.StackTrace);
			if (ex.InnerException != null) {
				txt.AppendLine("InnerException.toString(): " + ex.InnerException.ToString());
			}

			Log(txt.ToString());
		}

		// useful with dynamic types
		public static bool IsPropertyExist(dynamic settings, string name) {
			return settings.GetType().GetProperty(name) != null;
		}

		public static object GetCallingControl(dynamic item, object dummy) {
			if (!IsPropertyExist(item, "Owner")) {
				Debug.WriteLine("Owner doesn't exit!");
				return null;
			}

			Type type = dummy.GetType();
			var owner = (ContextMenuStrip)item.Owner;
			return Convert.ChangeType(owner.SourceControl, type);
		}

		public static Timer CreateTimer(int interval, Action<Timer> onTick) {
			Timer timer = new Timer();
			timer.Interval = interval;
			timer.Tick += (s, e) => {
				onTick(timer);
			};
			timer.Start();
			return timer;
		}

		public static void Delay(int delay, Action action) {
			Timer timer = new Timer();
			timer.Interval = delay;
			timer.Tick += (s, e) => {
				timer.Stop();
				action();
			};
			timer.Start();
		}

		public static Exception TryDeleteFile(string filePath) {
			try {
				if (File.Exists(filePath)) {
					File.Delete(filePath);
				}
			} catch (Exception ex) {
				return ex;
			}
			return null;
		}

		public static string IncrementVers(string vers, int add) {
			// check for new Vers
			string[] numStrs = vers.Split('.');
			string newVers = "";
			if (numStrs.Length == 4) {
				int thousands = Int32.Parse(numStrs[0]) * 1000;
				int hundreds = Int32.Parse(numStrs[1]) * 100;
				int tens = Int32.Parse(numStrs[2]) * 10;
				int ones = Int32.Parse(numStrs[3]);
				int num = thousands + hundreds + tens + ones + add;

				int newThousands = num / 1000;
				int newHundreds = (num - newThousands * 1000) / 100;
				int newTens = (num - newThousands * 1000 - newHundreds * 100) / 10;
				int newOnes = num - newThousands * 1000 - newHundreds * 100 - newTens * 10;
				newVers = newThousands + "." + newHundreds + "." + newTens + "." + newOnes;
			} else if (numStrs.Length == 3) {
				int hundreds = Int32.Parse(numStrs[0]) * 100;
				int tens = Int32.Parse(numStrs[1]) * 10;
				int ones = Int32.Parse(numStrs[2]);
				int num = hundreds + tens + ones + add;

				int newHundreds = num / 100;
				int newTens = (num - newHundreds * 100) / 10;
				int newOnes = num - newHundreds * 100 - newTens * 10;
				newVers = newHundreds + "." + newTens + "." + newOnes;
			}
			return newVers;
		}

		public static long GetDirectorySize(string dirPath) {
			// 1.
			// Get array of all file names.
			string[] filePaths = Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories);

			// 2.
			// Calculate total bytes of all files in a loop.
			long totalBytes = 0;
			foreach (string filePath in filePaths) {
				// 3.
				// Use FileInfo to get length of each file.
				FileInfo info = new FileInfo(filePath);
				totalBytes += info.Length;
			}
			// 4.
			// Return total size
			return totalBytes;
		}

		public static string GetDotaDir() {
			string dotaDir = "";
			// Auto-find the dota path.
			Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.LocalMachine;
			try {
				regKey =
					regKey.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 570");
				if (regKey != null) {
					string dir = regKey.GetValue("InstallLocation").ToString();
					dotaDir = dir;
				}
			} catch (Exception) { }

			if (dotaDir != "") {
				return dotaDir;
			}

			// try another way to auto-get the dir
			string p1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
			string p2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

			p1 = Path.Combine(p1, "steam", "steamapps", "common", "dota 2 beta");
			p2 = Path.Combine(p2, "steam", "steamapps", "common", "dota 2 beta");

			if (Directory.Exists(p1)) {
				dotaDir = p1;
			} else if (Directory.Exists(p2)) {
				dotaDir = p2;
			}

			// try another
			p1 = Path.Combine(p1, "steam", "steamapps", "common", "dota 2");
			p2 = Path.Combine(p2, "steam", "steamapps", "common", "dota 2");

			if (Directory.Exists(p1)) {
				dotaDir = p1;
			} else if (Directory.Exists(p2)) {
				dotaDir = p2;
			}
			return dotaDir;
		}

		public static bool HasSameDrives(string path1, string path2) {
			// D2ModKit must be ran from the same drive as dota or else things will break.
			char path1Drive = path1[0];
			char path2Drive = path2[0];
			if (path1Drive != path2Drive) {
				return false;
			}
			return true;
		}


	}
}
