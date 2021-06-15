using System.Threading.Tasks;

namespace Logic
{
    public interface IAuthenticationUseCases
    {
        Task<string> GetUserInfoAsync(string token);
        Task<string> LoginAsync(string userName, string password);
        Task Logout();
    }
}