using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterChallengeSolution.Models
{
    public class TwitterViewModel
    {
        public string text { get; set; }
        public string id_str { get; set; }

        public string ProfileImageurl {get;set;}
        public string ProfileBannerImageurl { get; set; }
        public string Username { get; set; }
        public string ScreenUserName { get; set; }
        public string TweetDate { get; set; }
        public int ReTweetsCount { get; set; }
    }
}