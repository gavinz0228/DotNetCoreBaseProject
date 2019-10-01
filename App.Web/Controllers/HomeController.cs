using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Web.Models;
using App.Core.Interfaces;
using App.Core.Entities;
namespace App.Web.Controllers
{
    public class HomeController : Controller
    {
        IUserService _userService;
        ILogger _logger;
        public HomeController(IUserService userService, ILogger<HomeController> logger)
        {
            this._userService = userService;
            this._logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userService.ListUsers();
            this._logger.LogDebug($"{users.Count()} of users found.");
            return View(users);
        }
        [Route("/About")]
        public IActionResult About()
        {
            throw new Exception("Test global exception handling");
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
