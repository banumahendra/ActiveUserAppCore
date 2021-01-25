using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActiveUserAppBACore.Manager;
using ActiveUserAppDATA;
using Microsoft.AspNetCore.Mvc;

namespace ActiveUserAppCORE.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepositoryBO _userRepositoryBO;
        public UserController(IUserRepositoryBO userRepositoryBO)
        {
            _userRepositoryBO = userRepositoryBO;
        }
        public IActionResult Index()
        {
           List<User> users = _userRepositoryBO.GetUserDetails();
            return View(users);
        }
    }
}
