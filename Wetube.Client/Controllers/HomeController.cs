using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Wetube.Client.Models;

namespace Wetube.Client.Controllers
{
    [Route("/[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new UserVM());
        }

        public IActionResult NewUser()
        {
            return View(new UserVM());
        }

        [HttpPost]
        public IActionResult AddUserAccount(UserVM user)
        {
            if (ModelState.IsValid)
            {
                // UserRepository _ur = new UserRepository();
                // _ur.SaveUser(user.Username, user.Password, user.FirstName, user.LastName, user.Email);
                return RedirectToAction("AccountPage", "User", user);
            }
            return View("NewUser");
        }

        [HttpPost]
        public IActionResult ConfirmUser(UserVM user)
        {
            if (ModelState.IsValid)
            {
                // // find username and password in db
                // UserRepository _ur = new UserRepository();
                // List<Users> Users = _ur.GetUserInfo();

                // UserVM user2 = new UserVM();

                // user2.Username == Users.Username;

                // var usernames = Users.Find(u => u.Username == user.Username)
                // var passwords = Users.Fine(u => u.Password == user.Password)

                // if (usernames != null && passwords != null)
                // {
                //     // attach entire record from db to current model
                //     return RedirectToAction("AccountPage", "User", user2);
                // }
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

