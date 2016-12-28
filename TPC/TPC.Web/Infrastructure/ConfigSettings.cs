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

            SmptpServer = ConfigurationManager.AppSettings["SmtpServer"];
        }

        public static ConfigSettings Instance => _instance.Value;

        public bool IsUnderConstruction { get; private set; }
        public string SmptpServer { get; private set; }
    }
}