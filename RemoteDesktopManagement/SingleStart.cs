﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace RemoteDesktopManagement
{
    public class SingleStart
    {
        /// <summary>
        /// Check for other interfaces and launch if so
        /// </summary>
        public static bool Start()
        {
            var handle = GetOtherStartedWindow();
            if (handle.HasValue)
            {
                ShowOtherStartedWindow(handle.Value);
                return true;
            }
            return false;
        }

        public static IntPtr? GetOtherStartedWindow()
        {
            var name = Path.GetFileNameWithoutExtension(Assembly.GetCallingAssembly().Location);

            var currId = Process.GetCurrentProcess().Id;
            return Process.GetProcessesByName(name).FirstOrDefault(p => p.Id != currId)?.MainWindowHandle;
        }

        public static void ShowOtherStartedWindow(IntPtr handle)
        {
            ShowWindow(handle, 4);
        }

        [DllImport("user32.dll", EntryPoint = "ShowWindow", SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);
    }
}
