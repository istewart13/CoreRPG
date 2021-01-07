using System.Threading.Tasks;
using CoreRPG.Models;

namespace CoreRPG.Data
{
    public interface IAuthRepository
    {
        Task<int> Register(User user, string password);
        Task<string> Login(string user, string password);
        Task<bool> UserExists(string username);
    }
}