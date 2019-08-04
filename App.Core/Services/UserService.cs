using System.Threading.Tasks;
using App.Core.Interfaces;
using App.Core.Enties;

namespace App.Core.Services{
    public class UserService: IUserService{
        public IUnitOfWork _unitOfWork;
        public IUserRepository _userRepository;
        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._userRepository = userRepository;
        }
        public async Task AddUser(User user){
            this._userRepository.Add(user);
            await this._unitOfWork.CompleteAsync();
        }

        public Task<bool> Authenticate(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task ChangePassword(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}