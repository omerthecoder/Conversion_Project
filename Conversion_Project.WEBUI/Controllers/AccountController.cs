using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conversion_Project.WEBUI.Controllers
{
    using BL.Abstract;
    using Models;
    public class AccountController : Controller
    {
        
        IUserAccountBusiness _userAccountService;
        public AccountController(IUserAccountBusiness userAccountService)
        {
            _userAccountService = userAccountService;
        }
        [HttpGet("")]
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login(UserAccountVM userAccount)
        {
            if (_userAccountService.GetUser(userAccount.UserName, userAccount.Password) != null)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
        }
    }
}
