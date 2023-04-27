using VanSync.Data.Interfaces.Repositorys;
using VanSync.Data.Interfaces.Services;

namespace VanSync.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
    }
}
