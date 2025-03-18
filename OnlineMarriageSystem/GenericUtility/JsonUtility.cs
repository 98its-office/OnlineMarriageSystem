using Newtonsoft.Json.Linq;


namespace TestProject1_nunit.Framework.Framework_GenericUtility
{
    internal class JsonUtility
    {
        public string ToReadfromjson(string key)
        {
          //  string thepath = "C:\\Users\\ranja\\OneDrive\\Documents\\Visual Studio 2022\\C#_selenium_project\\repos\\TestProject1_nunit\\TestProject1_nunit\\Framework\\ActualCommonDataUtility\\CommonDataUtility.json";
            //string Path = "C:\\Users\\Adarsh\\source\\repos\\TestProject1_nunit\\TestProject1_nunit\\Framework\\ActualCommonDataUtility\\CommonDataUtility.json";
            string utilityvals = File.ReadAllText(IPathConstants.jsonpath);

            JToken ken = JToken.Parse(utilityvals);
            string? value = ken.SelectToken(key)?.Value<string>();
            return value;
        }
    }
}
