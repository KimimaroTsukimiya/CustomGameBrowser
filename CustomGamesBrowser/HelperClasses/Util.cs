using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CustomGamesBrowser {
	public static class Util {

		public static string incrementVers(string vers, int add) {
			//Debug.WriteLine("input: " + vers);
			// check for new Vers
			string[] numStrings = vers.Split('.');
			int thousands = Int32.Parse(numStrings[0]) * 1000;
			int hundreds = Int32.Parse(numStrings[1]) * 100;
			int tens = Int32.Parse(numStrings[2]) * 10;
			int ones = Int32.Parse(numStrings[3]);
			int num = thousands + hundreds + tens + ones + add;

			//Debug.WriteLine("new num: " + num);
			int newThousands = num / 1000;
			int newHundreds = (num - newThousands * 1000) / 100;
			int newTens = (num - newThousands * 1000 - newHundreds * 100) / 10;
			int newOnes = num - newThousands * 1000 - newHundreds * 100 - newTens * 10;
			string newVers = newThousands + "." + newHundreds + "." + newTens + "." + newOnes;
			//Debug.WriteLine("New vers: " + newVers);
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

		public static string getDotaDir() {
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
			} catch (Exception) {

			}

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

		public static bool hasSameDrives(string path1, string path2) {
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
