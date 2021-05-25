using MagentaSportwear.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MagentaSportwear.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminPanelController : Controller
    {

        private readonly ILogger<AdminPanelController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminPanelController(ILogger<AdminPanelController> logger, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _logger = logger;
        }

        // GET: AdminController
        public async Task<IActionResult> Index()
        {
            Console.WriteLine(_logger);

            var admins = (await _userManager
                .GetUsersInRoleAsync("Administrator"))
                .ToArray();

            var everyone = await _userManager.Users
                .ToArrayAsync();

            _ = new AdminPanelViewModel
            {
                Administrators = admins,
                Everyone = everyone
            };

            return View();
        }

        public async Task<ActionResult> Articulos()
        {
            var admins = (await _userManager
                .GetUsersInRoleAsync("Administrator"))
                .ToArray();

            var everyone = await _userManager.Users
                .ToArrayAsync();

            _ = new AdminPanelViewModel
            {
                Administrators = admins,
                Everyone = everyone
            };

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
