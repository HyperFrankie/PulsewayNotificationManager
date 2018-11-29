using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace PulsewayNotificationManager
{
    public class Systems
    {
        private const string ENDPOINT = "https://monitor.mbitz.nl/api/v2/";
        private const string USERNAME = "puls.lenard";
        private const string PASSWORD = "M4rc3nCO!$";

        public static dynamic GetSystems()
        {
            var client = new RestClient(ENDPOINT);
            client.Authenticator = new HttpBasicAuthenticator(USERNAME, PASSWORD);

            var request = new RestRequest("systems", Method.GET);

            request.AddParameter("limit", "50");
            request.AddParameter("offset", "0");

            var response = client.Execute(request) as RestResponse;
            var content = response.Content;
            return JsonConvert.DeserializeObject(content);
        }
    }
}