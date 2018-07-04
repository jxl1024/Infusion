using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infusion.Framework.Manager
{
    public class JsonManager
    {
        public static IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

        public static string GetValue(string key)
        {            
            return configuration[key];
        }
    }
}
