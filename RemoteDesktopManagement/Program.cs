using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RemoteDesktopManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Check this program. If there are other instances that have been started, this interface window will pop up
            var currProcess = Process.GetCurrentProcess();
            var process = Process.GetProcessesByName(currProcess.ProcessName);
            if (process.Length > 1) 
            {
                var hWnd = FindWindow(null, "Remote Desktop Management");
                GetWindowThreadProcessId(hWnd, out var pid);

                foreach (var p in process)
                {
                    if (pid == p.Id) continue;

                    //Minimize first and then maximize, otherwise sometimes it cannot be activated
                    ShowWindowAsync(hWnd, 6); 
                    ShowWindowAsync(hWnd, 3);
                    return;
                }
            }

            //Start the main interface
            Application.Run(new MainForm());
        }

        ///<summary>
        /// This function sets the display state of windows spawned by different threads
        /// </summary>
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);


        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr window, out int process);

        /// <summary>
        /// Find a form by its window title
        /// </summary>
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


    }
}
