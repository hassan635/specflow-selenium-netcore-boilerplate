using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace specflow_selenium_netcore_boilerplate.src.lib.helpers
{
    public static class TestSettingsManager
    {
        public static string GetSetting(string key)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "testsettings.json");
            string paramsJson = File.ReadAllText(path);
            JObject parsedTestCases = JObject.Parse(paramsJson);
            return parsedTestCases[key].ToObject<string>();
        }
    }
}
