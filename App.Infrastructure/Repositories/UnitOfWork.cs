using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using App.Core.Interfaces;

namespace App.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected DbContext _dbContext;
        public UnitOfWork(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task CompleteAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}