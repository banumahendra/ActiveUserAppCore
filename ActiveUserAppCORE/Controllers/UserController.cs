using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ActiveUserAppBACore.Manager;
using ActiveUserAppCORE.Models;
using ActiveUserAppDATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ActiveUserAppCORE.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepositoryBO _userRepositoryBO;
        public UserController(IUserRepositoryBO userRepositoryBO, ILogger<UserController> logger)
        {
            _userRepositoryBO = userRepositoryBO;
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Entered into Index view, UserController");

            try
            {
                List<User> users = _userRepositoryBO.GetUserDetails();

                if(users == null || users?.Count == 0 )
                {
                    users = new List<User>();

                    _logger.LogInformation("No Users fetched, Index,  UserController");
                }
                else
                {
                    _logger.LogInformation($"{users.Count} Users fetched,  UserController");
                }

                _logger.LogInformation("Rendering Index view, UserController");
                return View(users);
            }
            catch(Exception ex)
            {
                _logger.LogInformation("Error occured in Index view, UserController", ex.Message);
                return RedirectToAction("Error","Home",  new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
