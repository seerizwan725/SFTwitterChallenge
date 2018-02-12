using System.Collections.Generic;
using System.Threading.Tasks;

namespace TwitterAppBusiness
{
    public abstract class SocialMedia:ISocialMedia<ISocialMediaObject> 
    {
        public abstract Task<IEnumerable<ISocialMediaObject>> GetFeeds();
        public string UserName { get; set; }
    }
}
