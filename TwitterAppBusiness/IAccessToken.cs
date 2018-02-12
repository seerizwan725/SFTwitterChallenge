using System.Threading.Tasks;

namespace TwitterAppBusiness
{
    public interface IAccessToken
    {
        Task<string> CreateAccessToken();

    }
}
