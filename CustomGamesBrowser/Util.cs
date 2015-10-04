using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CustomGamesBrowser {
	public static class Util {

		public static bool DownloadRemoteImageFile(string uri, string fileName) {
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			HttpWebResponse response;
			try {
				response = (HttpWebResponse)request.GetResponse();
			} catch (Exception) {
				return false;
			}

			// Check that the remote file was found. The ContentType
			// check is performed since a request for a non-existent
			// image file might be redirected to a 404-page, which would
			// yield the StatusCode "OK", even though the image was not
			// found.
			if ((response.StatusCode == HttpStatusCode.OK ||
				response.StatusCode == HttpStatusCode.Moved ||
				response.StatusCode == HttpStatusCode.Redirect) &&
				response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase)) {

				// if the remote file was found, download it
				using (Stream inputStream = response.GetResponseStream())
				using (Stream outputStream = File.OpenWrite(fileName)) {
					byte[] buffer = new byte[4096];
					int bytesRead;
					do {
						bytesRead = inputStream.Read(buffer, 0, buffer.Length);
						outputStream.Write(buffer, 0, bytesRead);
					} while (bytesRead != 0);
				}
				return true;
			} else
				return false;
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
