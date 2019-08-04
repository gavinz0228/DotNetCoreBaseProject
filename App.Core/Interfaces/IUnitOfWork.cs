using System.Threading.Tasks;
using App.Core.Entities;

namespace App.Core.Interfaces{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}