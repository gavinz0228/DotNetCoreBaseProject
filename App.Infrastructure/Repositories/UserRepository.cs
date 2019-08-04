using Microsoft.EntityFrameworkCore;
using App.Core.Interfaces;
using App.Core.Enties;
using App.Infrastructure.Data;
namespace App.Infrastructure.Repositories{
    public class UserRepository: BaseRepository<User>{
        public UserRepository(DataContext dbContext):base(dbContext){

        }

    }
}