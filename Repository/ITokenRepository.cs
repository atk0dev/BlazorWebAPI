using System.Threading.Tasks;

namespace Repository
{
    public interface ITokenRepository
    {
        Task<string> GetToken();
        Task SetToken(string token);
    }
}