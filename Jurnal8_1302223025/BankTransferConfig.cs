using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Jurnal8_1302223025
{
    public class Config
    {
        public string username { get; set; }
        public string password { get; set; }

        public Config() { }

        public Config( string username, string password)
        {
            this.username = username;
            this.password = password;
        }

    }

        public class BankTransferConfig()
        {
            public Config config;
            public const string filepath = "D:\\modul15_1302223025\\Jurnal8_1302223025\\bank_transfer_config.json";

            public Config ReadConfigFile()
            {
                string jsonData = File.ReadAllText(filepath);
                config = JsonSerializer.Deserialize<Config>(jsonData);
                return config;
            }

            public void WriteNewConfigFile()
            {
                string jsonData = JsonSerializer.Serialize(config);
                File.WriteAllText(filepath, jsonData);
            }
        }
}
