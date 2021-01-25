using ActiveUserAppBA.Contractor;
using ActiveUserAppDATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActiveUserAppMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            UserBA userBA = new UserBA();
            List<User> users = userBA.GetUserDetails();

            return View(users);
        }
    }
}