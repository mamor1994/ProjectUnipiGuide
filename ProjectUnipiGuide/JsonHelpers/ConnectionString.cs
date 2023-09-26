using Newtonsoft.Json;
using ProjectUnipiGuide.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static ProjectUnipiGuide.Models.Aplication;

namespace ProjectUnipiGuide.JsonHelpers
{
    internal static class ConnectionString
    {
        public static ApplicationSettings Get()
        {
            ApplicationSettings settings = new ApplicationSettings();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            using (StreamReader sr = new StreamReader(path))
            {
                var json = sr.ReadToEnd();
                settings = JsonConvert.DeserializeObject<ApplicationSettings>(json);
                
            }
            return settings;
        }
    }
}
