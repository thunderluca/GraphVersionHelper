using System.Collections.Generic;
using System.Linq;

namespace GraphVersionHelper
{
    public class GraphItem
    {
        /// <summary>
        /// Latest tested and working version of Graph API.
        /// </summary>
        public string Version { get; private set; }

        /// <summary>
        /// Base url to be used for Graph API requests.
        /// </summary>
        public string BaseUrl { get; private set; }

        /// <summary>
        /// Tested and working previous versions.
        /// </summary>
        public IList<string> Previous { get; private set; }

        public GraphItem(IList<string> versions)
        {
            Version = versions.Last();
            BaseUrl = VersionHelper.GraphBaseUrl + versions.Last();
            versions.RemoveAt(versions.Count - 1);
            Previous = versions;
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
