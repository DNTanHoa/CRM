using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.SharedUltilities.Global
{
    public class AppGlobal
    {
        public static string DefaultCode => DateTime.Now.ToString("yyyyMMddHHmmssfff");
        public static string TokenSecretKey
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Config")
                    .GetSection("TokenSecretKey").Value;
            }
        }
    }
}
