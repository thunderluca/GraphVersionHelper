using System.Collections.Generic;
using System.Linq;

namespace GraphVersionHelper
{
    public class GraphItem
    {
        /// <summary>
        /// Latest tested and working version of Graph API.
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// Base url to be used for Graph API requests.
        /// </summary>
        public string BaseUrl { get; private set; }

        /// <summary>
        /// Tested and working previous versions.
        /// </summary>
        public IList<string> Previous { get; private set; }

        public GraphItem(IEnumerable<double> versions)
        {
            //Forcing the string conversion using point instead of comma
            var versionStr = versions.Select(v => "v" + v.ToString("F1").Replace(',', '.')).ToList(); 

            Version = versionStr.Last();
            BaseUrl = VersionHelper.GraphBaseUrl + versionStr.Last();
            versionStr.RemoveAt(versionStr.Count - 1);
            Previous = versionStr;
        }

        /// <summary>
        /// Get latest version in string type.
        /// </summary>
        public override string ToString()
        {
            return Version;
        }
    }
}
