using System.Threading.Tasks;

namespace MinecraftPlayers.Services
{
    public interface IAuth
    {
        Task<string> SignInWithEmail(string email, string password);
        Task<string> SignUpWithEmail(string email, string password);
    }
}
