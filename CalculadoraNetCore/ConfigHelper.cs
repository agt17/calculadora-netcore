using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraNetCore
{
    public static class ConfigHelper
    {
        public static IConfiguration Configuration
        {
            get
            {
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
                return builder.Build();
            }
        }
    }
}
