using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VanSync.Data.Interfaces.Services;
using VanSync.Models;

namespace VanSync.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger,
                              IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}