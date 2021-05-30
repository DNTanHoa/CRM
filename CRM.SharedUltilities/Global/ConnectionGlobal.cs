﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.SharedUltilities.Global
{
    public class ConnectionGlobal
    {
        public static string DatabaseConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                return builder.Build().GetSection("Connections")
                    .GetSection("DatabaseConnectionString").Value;
            }
        }
    }
}
