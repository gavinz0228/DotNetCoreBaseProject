using System.Threading.Tasks;
using App.Core.Enties;

namespace App.Core.Interfaces{
    public interface IUserService
    {
        Task AddUser(User user);
        Task<bool> Authenticate(User user);
        Task ChangePassword(User user);
    }
}