using System;
using System.IO;
using ClashRoyale.Logic.Battle;
using ClashRoyale.Logic.Home;
using ClashRoyale.Logic.Home.Shop;
using Newtonsoft.Json;

namespace ClashRoyale.Core
{
    public class Configuration
    {
        [JsonIgnore]
        public static JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            ObjectCreationHandling = ObjectCreationHandling.Reuse,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            TypeNameHandling = TypeNameHandling.Auto,
            Formatting = Formatting.None
        };

        // Make sure to edit these on prod
        [JsonProperty("cluster_encryption_key")]
        public string ClusterKey = "15uvmi8qnyuj9tm53ipaavvytltm582yatecyjzb";

        [JsonProperty("cluster_encryption_nonce")]
        public string ClusterNonce = "nonce";

        [JsonProperty("cluster_server_port")] public int ClusterServerPort = 9876;

        [JsonProperty("encryption_key")] public string EncryptionKey = "fhsd6f86f67rt8fw78fw789we78r9789wer6re";

        [JsonProperty("mysql_database")] public string MySqlDatabase = "rrdb";
        [JsonProperty("mysql_password")] public string MySqlPassword = "";
        [JsonProperty("mysql_server")] public string MySqlServer = "127.0.0.1";
        [JsonProperty("mysql_user")] public string MySqlUserId = "root";
        [JsonProperty("patch_url")] public string PatchUrl = "";
        [JsonProperty("sentry_api")] public string SentryApiUrl = "";
        [JsonProperty("server_port")] public int ServerPort = 9339;
        [JsonProperty("update_url")] public string UpdateUrl = "https://github.com/retroroyale/ClashRoyale";
        [JsonProperty("use_content_patch")] public bool UseContentPatch;
        [JsonProperty("MinTrophies")] public int MinTroph;
        [JsonProperty("MaxTrophies")] public int MaxTroph;
        [JsonProperty("DefaultGold")] public int DefGold;
        [JsonProperty("DefaultGems")] public int DefGems;
        [JsonProperty("DefaultLevel")] public int DefLevel;
        [JsonProperty("use_udp")] public bool UseUdp;
        [JsonProperty("enable_epic_sunday")] public bool enable_epic_sunday;
        [JsonProperty("BattleLog_WebhookUrl")] public string BL_Webhook;
        [JsonProperty("PlayerLog_WebhookUrl")] public string Plr_Webhook;
        [JsonProperty("ServerLog_WebhookUrl")] public string Srv_Webhook;
        [JsonProperty("AdminID1")] public int admin1;
        [JsonProperty("AdminID2")] public int admin2;
        [JsonProperty("AdminID3")] public int admin3;
        [JsonProperty("GemsToGiveAfterMatch")] public int gemsreward;
        [JsonProperty("GoldToGiveAfterMatch")] public int goldreward;
        [JsonProperty("ErrorLogWebhook")] public string error_webhook;





        /// <summary>
        ///     Loads the configuration
        /// </summary>
        public void Initialize()
        {
            if (File.Exists("config.json"))
                try
                {
                    var config = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText("config.json"));

                    EncryptionKey = config.EncryptionKey;
                    SentryApiUrl = config.SentryApiUrl;

                    MySqlUserId = config.MySqlUserId;
                    MySqlServer = config.MySqlServer;
                    MySqlPassword = config.MySqlPassword;
                    MySqlDatabase = config.MySqlDatabase;

                    PatchUrl = config.PatchUrl;
                    UseContentPatch = config.UseContentPatch;

                    ServerPort = config.ServerPort;
                    UpdateUrl = config.UpdateUrl;

                    UseUdp = config.UseUdp;
                    ClusterServerPort = config.ClusterServerPort;

                    ClusterKey = config.ClusterKey;
                    ClusterNonce = config.ClusterNonce;
                    LogicBattle.MinTrophies = config.MinTroph;
                    LogicBattle.MaxTrophy = config.MaxTroph;
                    Home.DefaultGems = config.DefGems;
                    Home.DefaultLevel = config.DefLevel;
                    Home.DefaultGold = config.DefGold;
                    Srv_Webhook = config.Srv_Webhook;
                    Plr_Webhook = config.Plr_Webhook;
                    BL_Webhook = config.BL_Webhook;
                    Shop.enable_epic_sunday = config.enable_epic_sunday;
                    admin1 = config.admin1;
                    admin2 = config.admin2;
                    admin3 = config.admin3;

                    gemsreward = config.gemsreward;
                    goldreward = config.goldreward;
                    error_webhook = config.error_webhook;
                }
                catch (Exception)
                {
                    Console.WriteLine("Couldn't load configuration.");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
            else
                try
                {
                    Save();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Server configuration has been created. Restart the server now.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Couldn't create config file.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
        }

        public void Save()
        {
            File.WriteAllText("config.json", JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
