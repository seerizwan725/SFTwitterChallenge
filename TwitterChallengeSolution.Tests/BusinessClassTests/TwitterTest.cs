using System.Collections.Generic;
using System.Linq;
using LinqToTwitter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Language.Flow;
using TwitterAppBusiness;

namespace TwitterChallengeSolution.Tests.BusinessClassTests
{
    [TestClass]
    public class TwitterTest
    {
        

        [TestMethod]
        public void CanGetSfTweets()
        {

            var mytweets = CreateTweet();
            Assert.IsTrue(mytweets!=null);
            
        }

        private IEnumerable<IReturnsResult<Twitter>> CreateTweet()
        {
            var mocktwitter = new Mock<ISocialMediaObject>();
            var mockAccessToken = new Mock<IAccessToken>();
            var twitter = new Mock<Twitter>(mockAccessToken, 10, "salesforce");
            IEnumerable<TwitterMediaObject> testmediaobjectList = new List<TwitterMediaObject>();
            var testmediaobject1= new TwitterMediaObject();
            var testmediaobject2 = new TwitterMediaObject();
            var testmediaobject3 = new TwitterMediaObject();
            var testmediaobject4 = new TwitterMediaObject();
            var testmediaobject5 = new TwitterMediaObject();
            var testmediaobject6 = new TwitterMediaObject();
            var testmediaobject7 = new TwitterMediaObject();
            var testmediaobject8 = new TwitterMediaObject();
            var testmediaobject9 = new TwitterMediaObject();
            var testmediaobject10 = new TwitterMediaObject();

            testmediaobjectList.ToList().Add(testmediaobject1);
            testmediaobjectList.ToList().Add(testmediaobject2);
            testmediaobjectList.ToList().Add(testmediaobject3);
            testmediaobjectList.ToList().Add(testmediaobject4);
            testmediaobjectList.ToList().Add(testmediaobject5);
            testmediaobjectList.ToList().Add(testmediaobject6);
            testmediaobjectList.ToList().Add(testmediaobject7);
            testmediaobjectList.ToList().Add(testmediaobject8);
            testmediaobjectList.ToList().Add(testmediaobject9);
            testmediaobjectList.ToList().Add(testmediaobject10);
            var returnObject = twitter.Setup(data => data.GetFeeds()).ReturnsAsync(testmediaobjectList);
            return returnObject.ToEnumerable();

        }
    }
}
