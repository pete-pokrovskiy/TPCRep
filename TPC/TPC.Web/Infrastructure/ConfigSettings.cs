using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TPC.Web.Infrastructure
{
    /// <summary>
    /// Синглтон с настрйоками приложения
    /// </summary>
    public sealed class ConfigSettings 
    {
        private static readonly Lazy<ConfigSettings> _instance = new Lazy<ConfigSettings>(() => new ConfigSettings());

        private ConfigSettings()
        {
            var isUnderConstruction = ConfigurationManager.AppSettings["IsUnderConstruction"];
            if (isUnderConstruction == null)
                throw new Exception($"Отсутствует ключ {"IsUnderConstruction"} в конфиге");
            IsUnderConstruction = Convert.ToBoolean(isUnderConstruction);

            var isTestMode = ConfigurationManager.AppSettings["IsTestMode"];
            if (isTestMode == null)
                throw new Exception($"Отсутствует ключ {"IsTestMode"} в конфиге");
            IsTestMode = Convert.ToBoolean(isTestMode);

            SmptpServer = ConfigurationManager.AppSettings["SmtpServer"];
            SmptpPort = ConfigurationManager.AppSettings["SmptpPort"];

            Recipient = ConfigurationManager.AppSettings["Recipient"];
            TestRecipient = ConfigurationManager.AppSettings["TestRecipient"];
        }

        public static ConfigSettings Instance => _instance.Value;

        public bool IsUnderConstruction { get; private set; }
        public string SmptpServer { get; private set; }
        public string SmptpPort { get; set; }

        public bool IsTestMode { get; set; }

        public string Recipient { get; set; }
        public string TestRecipient { get; set; }
    }
}