using Microsoft.EntityFrameworkCore;
using App.Core.Interfaces;
using App.Core.Entities;
using App.Infrastructure.Data;
namespace App.Infrastructure.Repositories{
    public class UserRepository: BaseRepository<User>, IUserRepository{
        public UserRepository(DataContext dbContext):base(dbContext){

        }

    }
}