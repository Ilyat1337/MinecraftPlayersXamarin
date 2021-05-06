using MinecraftPlayers.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MinecraftPlayers.Services
{
    public interface IStorageService
    {
        ObservableCollection<User> GetUsers();
        Task AddUser(User user);
        Task UpdateUser(User user);
    }
}
