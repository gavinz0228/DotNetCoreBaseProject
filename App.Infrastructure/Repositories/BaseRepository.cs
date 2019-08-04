using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.Core.Interfaces;
using App.Core.Entities;
using App.Infrastructure.Data;

namespace App.Infrastructure.Repositories{
    public abstract class BaseRepository<T>: IAsyncRepository<T> where T: BaseEntity
    {
        protected DataContext _dbContext;
        public BaseRepository(DataContext dbContext){
            this._dbContext = dbContext;
        }
         public void Add(T entity)
         {
             this._dbContext.Set<T>().Add(entity);
         }
         public void Update(T entity)
         {
             this._dbContext.Entry(entity).State = EntityState.Modified;
         }
         public void Delete(T entity)
         {
             this._dbContext.Set<T>().Remove(entity);
         }
         public async Task<T> GetById(int id)
         {
            return await this._dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<IEnumerable<T>> ListAsync()
        {
            return await this._dbContext.Set<T>().ToListAsync();
        }
        public  async Task<IEnumerable<T>> ListAsync(ISpecification<T> specification)
        {
            return await ApplySpecification(specification).ToListAsync();
        }        
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>().AsQueryable(), spec);
        }
    } 
}