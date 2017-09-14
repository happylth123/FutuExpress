using FutuExpress.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FutuExpress.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var context = new ExpressDbContext();
            var users = context.Users.ToList();
            return View(users);
        }
    }
}