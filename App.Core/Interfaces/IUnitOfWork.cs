using System.Threading.Tasks;
using App.Core.Enties;

namespace App.Core.Interfaces{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}