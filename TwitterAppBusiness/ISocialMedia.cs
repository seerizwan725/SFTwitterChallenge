using System.Collections.Generic;
using System.Threading.Tasks;

namespace TwitterAppBusiness
{
    public interface ISocialMedia<T>
    {
        Task<IEnumerable<T>> GetFeeds();
        string UserName { get; set; }


    }
}
