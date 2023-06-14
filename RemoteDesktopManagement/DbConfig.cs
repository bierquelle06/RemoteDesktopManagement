using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using RemoteDesktopManagement.Properties;

namespace RemoteDesktopManagement
{
    public class Database
    {
        public string ConnectionString { get; set; }
    }

    public class DbConfiguration
    {
        public Database Database { get; set; }
    }
}
