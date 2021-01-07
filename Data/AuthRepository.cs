using System.Security.Cryptography;
using System.Threading.Tasks;
using CoreRPG.Models;

namespace CoreRPG.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public Task<string> Login(string user, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<int> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}