using System.Collections.Generic;

namespace TwitterAppBusiness
{
    interface IFaceBook:ISocialMedia<ISocialMediaObject>
    {
        IEnumerable<string> GetFriendNamesList();
    }
}
