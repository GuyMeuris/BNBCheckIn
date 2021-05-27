using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BnBCheckIn_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<User> _roleManager;

        public AccountController(SignInManager<User> _signInManager, UserManager<User> _userManager, RoleManager<User> _roleManager)
        {
            this._signInManager = _signInManager;
            this._userManager = _userManager;
            this._roleManager = _roleManager;
        }
        
    }
}
