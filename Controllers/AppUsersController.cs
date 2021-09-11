using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BugTracker.Data;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace BugTracker.Controllers
{
    public class AppUsersController : Controller
    {
        private readonly RaidContext _context;
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }
        private RoleManager<AppRole> RoleManager { get; }


        public AppUsersController(RaidContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            UserMgr = userManager;
            SignInMgr = signInManager;
            RoleManager = roleManager;
        }

        // GET: AppUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppUsers.ToListAsync());
        }

        // GET: AppUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            /*
            // Select the user based on the id with userManager; return an error if user doesn't exist
            var user = await _context.AppUsers
                .Include(au => au.UserIssues)
                    .ThenInclude(ui => ui.Issue)
                .Include(au => au.IssueComments)
                    .ThenInclude(ic => ic.Issue)
                .FirstOrDefaultAsync(u => u.Id == id);
            */

            // Get user's username and confirm that user exists
            var currentUser = await _context.AppUsers
                .FirstOrDefaultAsync(au => au.Id == id);

            if (currentUser == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            var currentUserName = currentUser.UserName;

            // Get issues for this user
            var userIssues = await _context.AppUsers
                .Include(au => au.UserIssues)
                    .ThenInclude(ui => ui.Issue)
                .FirstOrDefaultAsync(u => u.Id == id);

            var assignedIssues = from ui in userIssues.UserIssues
                                 select ui.Issue;

            // Get comments from this user
            var issueComments = _context.IssueComments
                .Where(ic => ic.UserCreated == currentUserName)
                .Include(ic => ic.Issue);

            // Create view model
            UserDetailsViewModel viewModel = new UserDetailsViewModel
            {
                IssueComments = issueComments,
                Issues = assignedIssues,
                currentUserName = currentUserName
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Details(List<UserRolesViewModel> viewModelList, int id)
        {
            // Assign userId field in ViewBag based on the id passed to the controller
            ViewBag.userId = id;

            // Select the user based on the id with userManager; return an error if user doesn't exist
            var user = await _context.AppUsers
                .FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            // Remove roles from user to return to blank slate state before adding whatever roles are
            // checked in the View.
            var roles = await UserMgr.GetRolesAsync(user);
            var result = await UserMgr.RemoveFromRolesAsync(user, roles);

            // Throw error message if roles can't be removed.
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove selected roles from user");
                return View(viewModelList);
            }

            // Assuming that the roles could be removed, add whatever roles are selected to the user
            result = await UserMgr.AddToRolesAsync(user,
                viewModelList.Where(x => x.IsSelected)
                .Select(y => y.RoleName));

            // Throw error message if roles can't be added
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(viewModelList);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: AppUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appUser);
        }

        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.AppUsers.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            return View(appUser);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FirstName,LastName,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        {
            if (id != appUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppUserExists(appUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appUser);
        }

        // GET: AppUsers/Delete/5
        [Authorize("Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.AppUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // POST: AppUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appUser = await _context.AppUsers.FindAsync(id);
            _context.AppUsers.Remove(appUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserExists(int id)
        {
            return _context.AppUsers.Any(e => e.Id == id);
        }
    }
}
