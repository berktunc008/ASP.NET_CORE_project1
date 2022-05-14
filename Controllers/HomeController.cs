using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using webodevberk.Models;

namespace webodevberk.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly UserManager<IdentityUser> _usermanager;

        public HomeController(ILogger<HomeController>logger, RoleManager<IdentityRole> roleManager,UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _rolemanager = roleManager;
            _usermanager = userManager;
        }

        public async Task<IActionResult> CreateRole(string role)
        {
            await _rolemanager.CreateAsync(new IdentityRole(role));
            return Ok();
        }

        public async Task<IActionResult> AddRole(string username,string role)
        {
            var user = await _usermanager.FindByNameAsync(username);
            await _usermanager.AddToRoleAsync(user, role);
            return Ok();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Iletisim()
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
