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
            return View();
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
                // do something
            }
            return RedirectToAction("AccountPage", "User");
        }

        [HttpPost]
        public IActionResult ConfirmUser(FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                // do something
                return RedirectToAction("AccountPage", "User");
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
