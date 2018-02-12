using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitterAppBusiness
{
    public class Twitter:SocialMedia,ITwitter
    {
        private IAccessToken _accesstoken;
        private int _count;
        public Twitter(IAccessToken accesstoken, int count, string username)
        {
            //Injecting the access object to initialize AccessToken object in constructor
            _accesstoken = accesstoken;
            _count = count;
            base.UserName = username;
        }
        public override async Task<IEnumerable<ISocialMediaObject>> GetFeeds()
        {
            try
            {
                //Hitting the twitter api url and getting JSON
                var requestUserTimeline = new HttpRequestMessage(HttpMethod.Get,
                    string.Format(
                        "https://api.twitter.com/1.1/statuses/user_timeline.json?count={0}&screen_name={1}&exclude_replies=1",
                        _count, UserName));
                requestUserTimeline.Headers.Add("Authorization", "Bearer " + await _accesstoken.CreateAccessToken());
                var httpClient = new HttpClient();
                var responseUserTimeLine = await httpClient.SendAsync(requestUserTimeline);

                //The following serialization and then json string I used to create classes from JSON using Json2csharp.com
                //var serializer = new JavaScriptSerializer();
                //var jsonstr = serializer.ConvertToType<string>(await responseUserTimeLine.Content.ReadAsStringAsync());
                //==============================================================================================================

                //Async Read call and 
                //Deserialization and parsing JSON data to the object class and its properties
                var result = await responseUserTimeLine.Content.ReadAsStringAsync();
                var alltweetslist = JsonConvert.DeserializeObject<IEnumerable<TwitterMediaObject>>(result);
                return alltweetslist;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

       
    }
}
