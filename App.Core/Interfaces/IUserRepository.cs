using App.Core.Interfaces;
using App.Core.Entities;
namespace App.Core.Interfaces{
    public interface IUserRepository : IAsyncRepository<User>
    {
        
    }
}