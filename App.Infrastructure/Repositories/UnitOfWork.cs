using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using App.Core.Interfaces;
using App.Infrastructure.Data;
namespace App.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected DataContext _dbContext;
        public UnitOfWork(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task CompleteAsync()
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}