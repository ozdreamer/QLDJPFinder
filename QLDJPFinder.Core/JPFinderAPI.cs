using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QLDJPFinder.Core
{
    public class JPFinderAPI
    {
        private const string APIEndPoint = "https://data.qld.gov.au/api/action/datastore_search";

        private const string ResourceId = "652252e9-e21a-43fd-b761-3592b365fb28";

        public async Task<List<JPInfo>> GetJPList(string area, int limit = 10)
        {
            var jpCollection = new List<JPInfo>();
            var request = WebRequest.Create($"{APIEndPoint}?resource_id={ResourceId}&limit={limit}&q={area}");
            var response = await request.GetResponseAsync();
            using (var dataStream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(dataStream))
                {
                    string responseFromServer = reader.ReadToEnd();
                    var jpObject = JsonConvert.DeserializeObject<APIJSONObject>(responseFromServer);
                    return jpObject.Result.Records;
                }
            }
        }
    }
}