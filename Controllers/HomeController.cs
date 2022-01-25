using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BugTracker.ViewModels;
using BugTracker.Data;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly RaidContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public HomeController(RaidContext context, ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            // Initialize dashboard viewmodel
            var user = await _userManager.GetUserAsync(User);
            var currentUserId = user.Id;
            var currentUser = await _context.AppUsers
                .Include(au => au.RecentlyViewedIssues)
                    .ThenInclude(rvi => rvi.Issue)
                .FirstOrDefaultAsync(au => au.Id == currentUserId);

            DashboardViewModel viewModel = new DashboardViewModel
            {
                RecentlyViewedIssues = currentUser.RecentlyViewedIssues
            };

            return View(viewModel);
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
