using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsAppCamTest
{
	static class Program
	{
		static FormMain mainForm;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ApplicationExit += Application_ApplicationExit;

			string mutexStr = Environment.CommandLine.Replace('\\', '_').Replace('.', '_');
			bool isnew;
			Mutex m = new Mutex(true, mutexStr, out isnew);

			if (!isnew)
			{
				var res = MessageBox.Show("Another Instance is already open. Do you want to Kill other Instances ?", "Multi instance error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
				if (res == DialogResult.Yes)
				{
					Process current = Process.GetCurrentProcess();
					// get all the processes with currnent process name
					Process[] processes = Process.GetProcessesByName(current.ProcessName);
					foreach (Process process in processes)
					{
						//Ignore the current process  
						if (process.Id != current.Id && process.MainModule.FileName == current.MainModule.FileName)
						{
							process.Kill();
						}
					}

					mainForm = new FormMain();
					Application.Run(mainForm);
				}
				else
				{
					Application.Exit();
				}
			}
			else
			{
				mainForm = new FormMain();
				Application.Run(mainForm);
			}
		}

		private static void Application_ApplicationExit(object sender, EventArgs e)
		{
			mainForm.Form1_FormClosing(null, null);
			Application.Exit();
		}
	}
}
