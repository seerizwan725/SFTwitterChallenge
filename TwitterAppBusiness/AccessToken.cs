using System;
using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace TwitterAppBusiness
{
    public class AccessToken:IAccessToken
    {
        private string ConsumerKey { get; set; }
        private string ConsumerKeySecret { get; set; }

        public AccessToken(string consumerkey,string consumerkeysecret)
        {
            this.ConsumerKey = consumerkey;
            this.ConsumerKeySecret = consumerkeysecret;
        }

        public async Task<string> CreateAccessToken()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, ConfigurationManager.AppSettings["twitterrequesturi"]);
            var customerInfo = Convert.ToBase64String(new UTF8Encoding().GetBytes(ConsumerKey + ":" + ConsumerKeySecret));
            request.Headers.Add("Authorization", "Basic " + customerInfo);
            request.Content = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await httpClient.SendAsync(request);
            var json = await response.Content.ReadAsStringAsync();
            var serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(json);
            return item["access_token"];
        }

       
    }
}
