using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TPC.Web.Infrastructure
{
    public class ConfigSettings 
    {
        public static bool IsUnderConstruction
        {
            get
            {
                var isUnderConstruction = ConfigurationManager.AppSettings["IsUnderConstruction"];
                if(isUnderConstruction == null)
                    throw new Exception(string.Format("Отсутствует ключ {0} в конфиге", "IsUnderConstruction"));
                return Convert.ToBoolean(isUnderConstruction);
            }
        }
    }
}