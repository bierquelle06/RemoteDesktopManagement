using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Xml;
using Newtonsoft.Json;
using RemoteDesktopManagement.Properties;

namespace RemoteDesktopManagement
{
    public class Db
    {
        static Db()
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string appSettingsFile = Path.Combine(executableLocation, "appsettings.json");
            string appSettings = File.ReadAllText(appSettingsFile);

            DbConfiguration dbConfig = JsonConvert.DeserializeObject<DbConfiguration>(appSettings);

            Connection = new SqlConnection(dbConfig.Database.ConnectionString);
            Connection.Open();
        }

        public static readonly IDbConnection Connection;

    }
}
