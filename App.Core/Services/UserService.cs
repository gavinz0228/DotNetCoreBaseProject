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
            await this._userService.AddUser(user);
            await this._unitOfWork.CompleteAsync();
        }
    }
}