using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MaluFlix.Controllers;

    [Authorize(Roles = "Administrador")]

        public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult login(string returnUrl)
        {
            
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult login()
        {
            return View();
        }
    }
