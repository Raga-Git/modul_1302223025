using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jurnal8_1302223025
{
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public string[] methods { get; set; }
        public Confirmation confirmation { get; set; }

        public Config() { }

        public Config( string lang, Transfer transfer, string[] methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }

    }
        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set;}

        }
        public class Confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
        }
        public class BankTransferConfig()
        {
            public Config config;
            public const string filepath = "D:\\Tel U\\Semester 4\\KPL\\Jurnal8_1302223025\\Jurnal8_1302223025\\bank_transfer_config.json";

            public Config ReadConfigFile()
            {
                string jsonData = File.ReadAllText(filepath);
                config = JsonSerializer.Deserialize<Config>(jsonData);
                return config;
            }

            public void WriteNewConfigFile()
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                String jsonString = JsonSerializer.Serialize(config, options);
                File.WriteAllText(filepath, jsonString);
            }
            private void SetDefault()
            {
                Transfer Otransfer = new Transfer();
                Otransfer.threshold = 25000000;
                Otransfer.low_fee = 6500;
                Otransfer.high_fee = 15000;

                Confirmation confirm = new Confirmation();
                confirm.en = "yes";
                confirm.id = "ya";

                string[] method = { "RTO", "SKN", "RTGS", "BI FAST" };
                
                config = new Config(lang : "en", transfer : Otransfer, methods : method, confirmation : confirm);
            }
        }
}
