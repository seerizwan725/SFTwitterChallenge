using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using TwitterAppBusiness;
using TwitterChallengeSolution.Models;

namespace TwitterChallengeSolution.Controllers
{
    public class TwitterFeedsController : Controller
    {
        // GET: TwitterFeeds
        public async Task<ActionResult> Index()
        {
            var mytweets = new TwitterFeedViewModel();
            try
            {
                var tokn = CreateToken();
                var socialmediaobject = new Twitter(tokn, 10, "salesforce");
                var alldata = await socialmediaobject.GetFeeds();
                var enumerable = alldata.ToList();
                if (enumerable.Any())
                {
                    mytweets.AllTweets = new List<TwitterViewModel>();
                    foreach (var itm in enumerable)
                    {
                        var castedobject = itm as TwitterMediaObject;
                        var imgur = "";
                        
                        if (castedobject != null)
                        {
                            if (castedobject.entities?.urls != null && castedobject.entities.urls.Any())
                            {
                                imgur = castedobject.entities.urls[0].expanded_url;
                            }
                            mytweets.AllTweets.Add(
                                new TwitterViewModel
                                {
                                    text = castedobject.text,
                                    id_str = string.IsNullOrEmpty(castedobject.id_str)?"": castedobject.id_str,
                                    ProfileImageurl = castedobject.user.profile_image_url,
                                    ProfileBannerImageurl = castedobject.user.profile_banner_url,
                                    ScreenUserName =castedobject.user.screen_name,
                                    TweetDate = castedobject.created_at,
                                    ReTweetsCount = castedobject.retweet_count
                                }
                            );
                        }
                    }
                }
                else
                {
                    ViewBag.data = mytweets;
                    TempData["AllTweets"] = mytweets;
                    return View(mytweets);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            ViewBag.data = mytweets;
            TempData["AllTweets"]= mytweets;
            return View(mytweets);
        }

        [HttpPost]
        public ActionResult SearchInFeeds(string searchstring)
        {
            var searchedTweets= TempData["AllTweets"] as TwitterFeedViewModel;
            var newfeed= new TwitterFeedViewModel {AllTweets = new List<TwitterViewModel>()};
            if (searchedTweets != null)
            {
                foreach (var itm in searchedTweets.AllTweets)
                {
                    if (itm.text.Contains(searchstring))
                    {
                        newfeed.AllTweets.Add(itm);
                    }
                }
            }
            
            return View(newfeed);
        }


        private AccessToken CreateToken()
        {
            return new AccessToken(ConfigurationManager.AppSettings["consumerKey"], ConfigurationManager.AppSettings["consumerSecret"]);
        }
    }
}