using System.Collections.Generic;
using Newtonsoft.Json;

namespace TwitterAppBusiness
{
    //Classes generated from JSON object returned by twitter Api
    public class TwitterMediaObject:ISocialMediaObject
    {
        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("id")]
        public long id { get; set; }

        [JsonProperty("id_str")]
        public string id_str { get; set; }

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("truncated")]
        public bool truncated { get; set; }

        [JsonProperty("entities")]
        public Entities entities { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("in_reply_to_status_id")]
        public object in_reply_to_status_id { get; set; }

        [JsonProperty("in_reply_to_status_id_str")]
        public object in_reply_to_status_id_str { get; set; }

        [JsonProperty("in_reply_to_user_id")]
        public object in_reply_to_user_id { get; set; }
        [JsonProperty("in_reply_to_user_id_str")]
        public object in_reply_to_user_id_str { get; set; }
        [JsonProperty("in_reply_to_screen_name")]
        public object in_reply_to_screen_name { get; set; }
        [JsonProperty("user")]
        public User user { get; set; }
        [JsonProperty("geo")]
        public object geo { get; set; }
        [JsonProperty("coordinates")]
        public object coordinates { get; set; }
        [JsonProperty("place")]
        public object place { get; set; }
        [JsonProperty("contributors")]
        public object contributors { get; set; }
        [JsonProperty("is_quote_status")]
        public bool is_quote_status { get; set; }
        [JsonProperty("retweet_count")]
        public int retweet_count { get; set; }
        [JsonProperty("favorite_count")]
        public int favorite_count { get; set; }
        [JsonProperty("favorited")]
        public bool favorited { get; set; }
        [JsonProperty("retweeted")]
        public bool retweeted { get; set; }
        [JsonProperty("possibly_sensitive")]
        public bool possibly_sensitive { get; set; }
        [JsonProperty("lang")]
        public string lang { get; set; }
    }
    public class Url
    {
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("expanded_url")]
        public string expanded_url { get; set; }
        [JsonProperty("display_url")]
        public string display_url { get; set; }
        [JsonProperty("indices")]
        public List<int> indices { get; set; }
    }

    public class Entities
    {
        [JsonProperty("hashtags")]
        public List<object> hashtags { get; set; }
        [JsonProperty("symbols")]
        public List<object> symbols { get; set; }
        [JsonProperty("user_mentions")]
        public List<object> user_mentions { get; set; }
        [JsonProperty("urls")]
        public List<Url> urls { get; set; }
    }
    public class Url3
    {
        public string url { get; set; }
        public string expanded_url { get; set; }
        public string display_url { get; set; }
        public List<int> indices { get; set; }
    }
    public class Url2
    {
        public List<Url3> urls { get; set; }
    }

    public class Description
    {
        public List<object> urls { get; set; }
    }
    public class Entities2
    {
        public Url2 url { get; set; }
        public Description description { get; set; }
    }
    

        public class User
        {
            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("id_str")]
            public string id_str { get; set; }
            public string name { get; set; }
            public string screen_name { get; set; }
            public string location { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public Entities2 entities { get; set; }
            public bool @protected { get; set; }
            public int followers_count { get; set; }
            public int friends_count { get; set; }
            public int listed_count { get; set; }
            public string created_at { get; set; }
            public int favourites_count { get; set; }
            public int utc_offset { get; set; }
            public string time_zone { get; set; }
            public bool geo_enabled { get; set; }
            public bool verified { get; set; }
            public int statuses_count { get; set; }
            public string lang { get; set; }
            public bool contributors_enabled { get; set; }
            public bool is_translator { get; set; }
            public bool is_translation_enabled { get; set; }
            public string profile_background_color { get; set; }
            public string profile_background_image_url { get; set; }
            public string profile_background_image_url_https { get; set; }
            public bool profile_background_tile { get; set; }
            public string profile_image_url { get; set; }
            public string profile_image_url_https { get; set; }
            public string profile_banner_url { get; set; }
            public string profile_link_color { get; set; }
            public string profile_sidebar_border_color { get; set; }
            public string profile_sidebar_fill_color { get; set; }
            public string profile_text_color { get; set; }
            public bool profile_use_background_image { get; set; }
            public bool has_extended_profile { get; set; }
            public bool default_profile { get; set; }
            public bool default_profile_image { get; set; }
            public object following { get; set; }
            public object follow_request_sent { get; set; }
            public object notifications { get; set; }
            public string translator_type { get; set; }
        }
    
}
