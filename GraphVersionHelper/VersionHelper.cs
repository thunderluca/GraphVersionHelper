using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphVersionHelper
{
    public static class VersionHelper
    {
        public const string GraphBaseUrl = "https://graph.facebook.com";

        /// <summary>
        /// Get latest version of Graph API endpoint to use.
        /// </summary>
        public static async Task<GraphItem> GetLatestVersionAsync()
        {
            var isMajorVersionTried = false;
            var tested = new List<double>();
            var latestVersion = 2.3; //Minimal version
            do
            {
                //Forcing the string conversion using point instead of comma
                var verStr = latestVersion.ToString("F1").Replace(',', '.');

                var response = await new HttpClient().GetAsync(new Uri($"{GraphBaseUrl}/v{verStr}/facebook/picture"));
                
                //Not working version
                if (!response.IsSuccessStatusCode)
                {
                    if (isMajorVersionTried)
                        return new GraphItem(tested);

                    //Let's try if Facebook introduced 
                    //a new major version of Graph endpoint
                    latestVersion = (int)tested.First() + 1;

                    isMajorVersionTried = true;

                    continue;
                }

                //Working version, I add it
                if (tested.Count == 0 || tested.Last() < latestVersion)
                    tested.Add(latestVersion);

                latestVersion = latestVersion + 0.1;
            } while (true);
        }
    }
}
