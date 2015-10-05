using MetroFramework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomGamesBrowser {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public static MainForm mainForm;
		[STAThread]
		static void Main() {
			AppDomain.CurrentDomain.UnhandledException += (s, e) => {
				if (e.IsTerminating) {
					Exception ex = e.ExceptionObject as Exception;
					WriteCrash(ex);
				}
			};

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			mainForm = new MainForm();

			// Check if application is already running.
			if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count() > 1) {
				MetroMessageBox.Show(mainForm,
					"An instance of CustomGameBrowser is already running. Exiting.",
					"",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				Process.GetCurrentProcess().Kill();
			}

			Application.Run(mainForm);
		}

		private static void WriteCrash(Exception ex) {
			Util.LogException(ex);
			string msg = "CustomGameBrowser has crashed! A crash report has been created in " + Util.logPath;

			if (mainForm != null) {
				MetroMessageBox.Show(mainForm,
					msg,
					"Crash",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

			} else {
				MessageBox.Show(msg,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}

			Application.Exit();
		}
	}
}
