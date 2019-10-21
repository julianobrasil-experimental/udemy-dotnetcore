using System.Threading.Tasks;
using DatingApp.API.csproj.Models;

namespace DatingApp.API.csproj.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user,
                            string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}