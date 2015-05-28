using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphVersionHelper
{
    public static class VersionHelper
    {
        public const string GraphBaseUrl = "https://graph.facebook.com/";

        /// <summary>
        /// Get latest version of Graph API endpoint to use.
        /// </summary>
        public static async Task<GraphItem> GetLatestVersionAsync()
        {
            var tested = new List<string> { "v2.0" }; //Minimal version
            var latestVersion = "v2.0";
            do
            {
                var response = new HttpClient().GetAsync(new Uri(GraphBaseUrl + latestVersion + "/facebook/picture"));
                Task.WaitAll(response);
                if (!response.Result.IsSuccessStatusCode)
                {
                    return new GraphItem(tested);
                }
                if (tested.Last() != latestVersion)
                    tested.Add(latestVersion);
                var splittedVersion = latestVersion.Split('.');
                var lastNum = int.Parse(splittedVersion.Last());
                if (lastNum < 9)
                {
                    lastNum++;
                    latestVersion = splittedVersion.First() + "." + lastNum;
                }
                else
                {
                    var mainNum = int.Parse(splittedVersion.First()[1].ToString());
                    mainNum++;
                    latestVersion = "v" + mainNum + ".0";
                }
            } while (true);
        }
    }
}
