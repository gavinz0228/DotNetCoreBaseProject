using System.Threading.Tasks;
using System.Collections.Generic;
using App.Core.Entities;
namespace App.Core.Interfaces{
    public interface IAsyncRepository<T>  where T : BaseEntity
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> GetById(int id);
        void Delete(T entity);
        void Add(T entity);
        void Update(T entity);
        Task<IEnumerable<T>> ListAsync(ISpecification<T> specification); 
    }
}