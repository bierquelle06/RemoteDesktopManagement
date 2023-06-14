using System.Collections.Generic;

namespace RemoteDesktopManagement.Model
{
    public class GlobalConfig
    {
        public static GlobalConfig Instance { get; set; }


        /// <summary>
        /// Username
        /// </summary>
        public string User { get; set; } = "Administrator";

        /// <summary>
        /// Password
        /// </summary>
        public string Pwd { get; set; }

        /// <summary>
        /// Connect Session
        /// </summary>
        public bool ConnectSession0 { get; set; } = false;

        /// <summary>
        /// Share All Disks
        /// </summary>
        public bool ShareAllDisk { get; set; } = true;

        /// <summary>
        /// List of shared disks, used when ShareAllDisk = false
        /// </summary>
        public List<string> ShareDiskList { get; set; } = new List<string>();
    }
}
