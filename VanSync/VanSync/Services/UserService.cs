using VanSync.Data.Interfaces.Repositorys;
using VanSync.Data.Interfaces.Services;

namespace VanSync.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}
