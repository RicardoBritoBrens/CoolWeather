using System;
using System.IO;
using System.Reflection;

namespace CoolWeather.Extra
{
    public static class Utils
    {
        public static string ReadEmbeddedJsonFile()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(Properties.FullPathCityListJsonFile);
            string text = string.Empty;

            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            return text;
        }
    }
}
