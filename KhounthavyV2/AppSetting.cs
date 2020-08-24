using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace KhounthavyV2
{
    class AppSetting
    {
        Configuration config;
        public AppSetting()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public String GetConnStr(string key)//key is name.
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void SaveConnStr(String key, String value)
        {
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}
