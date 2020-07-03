using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace TA_PBO
{
    class Unsur
    {
        public UnsurResult ReturnValue(string url, string unsur)
        {
            UnsurResult unsurResult = new UnsurResult();
            string customURL = Url(url, unsur);
            var client = new RestClient(customURL);
            var response = client.Execute<List<UnsurResult>>(new RestRequest());
            unsurResult = JsonConvert.DeserializeObject<UnsurResult>(response.Content);

            return unsurResult;
        }
        public string Url(string url, string unsur)
        {
            string customURL = string.Format(url + "/" + unsur.ToLower());
            return customURL;
        }
    }
}
