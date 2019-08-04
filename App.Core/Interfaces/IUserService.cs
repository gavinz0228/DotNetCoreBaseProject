using System.Collections.Generic;
using System.Threading.Tasks;
using App.Core.Entities;

namespace App.Core.Interfaces{
    public interface IUserService
    {
        Task AddUser(User user);
        Task<IEnumerable<User>> ListUsers();
        Task<bool> Authenticate(User user);
        Task ChangePassword(User user);
    }
}