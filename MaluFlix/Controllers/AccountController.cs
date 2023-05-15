using MaluFlix.DataTransferObjects;
using MaluFlix.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MaluFlix.Controllers;

    [Authorize(Roles = "Administrador")]

        public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<AppUser> SignInManager;
        private readonly UserManager<AppUser> UserManager;
        
        public AccountController(
        ILogger<AccountController> logger,
        SignInManager<AppUser> SignInManager,
        UserManager<AppUser> UserManager)
        {
            _logger = logger;
            _singInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult login(string returnUrl)
        {
            LoginDto loginDto = new();
            loginDto.ReturnUrl = returnUrl ?? Url.Content("~/"); 
            return View(loginDto);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult login(LoginDto login)
        {
            //se o model é valido, faz login
            if(ModelState.IsValid)
            {
                return LocalRedirect(login.ReturnUrl);
            }
            return View(login);
        }
    }
