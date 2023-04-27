using Microsoft.AspNetCore.Mvc;
using VanSync.Data.Interfaces.Services;

namespace VanSync.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IAdminService _adminService;

        public AdminController(ILogger<AdminController> logger,
                               IAdminService adminService)
        {
            _logger = logger;
            _adminService = adminService;   
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AttendanceListCreate()
        {
            return View();
        }
        public IActionResult AttendanceListDelete()
        {
            return View();
        }
        public IActionResult AttendanceListDetails()
        {
            return View();
        }
        public IActionResult AttendanceListEdit()
        {
            return View();
        }
        public IActionResult AttendanceListList()
        {
            return View();
        }
        public IActionResult UserCreate()
        {
            return View();
        }
        public IActionResult UserDelete()
        {
            return View();
        }
        public IActionResult UserDetails()
        {
            return View();
        }
        public IActionResult UserEdit()
        {
            return View();
        }
        public IActionResult UserList()
        {
            return View();
        }
    }
}