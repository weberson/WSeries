using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WSeries.Trakt
{
    public class TraktIntegration : ITraktIntegration
    {
        internal const string BASE_SERVER = "http://api.trakt.tv";
        internal const string API_KEY = "90f39b4da1cbb3101b51e73d0f263197afbf5f6e";

        public async Task<object> SearchShow(string title)
        {
            object shows = null;

            using (var client = new HttpClient())
            {
                string url = string.Format("{0}/search/movies.json/{1}/{2}", BASE_SERVER, API_KEY, title);
                var result = await client.GetAsync(url);
                if (result.IsSuccessStatusCode)
                {
                    var content = result.Content.ReadAsStringAsync();
                    shows = content;
                }
            }

            return shows;
        }

    }
}
