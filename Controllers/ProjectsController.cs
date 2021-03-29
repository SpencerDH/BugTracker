using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
    public class ProjectsController : Controller
    {
        private readonly RaidContext _context;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public ProjectsController(RaidContext context, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projects.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id, string? testInput)
        {

            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.ProjectTasks)
                    .ThenInclude(pt => pt.Issues)
                .FirstOrDefaultAsync(m => m.ID == id);

            var projectTasks = from pt in project.ProjectTasks
                               select pt;

            // Create TempData dictionary
            if (TempData["ViewModelsParamsDictionary"] == null)
            {
                Console.WriteLine("Dictionary was null");
                var paramsDict = new Dictionary<int, string>();
                foreach (var pt in projectTasks)
                {
                    paramsDict.Add(pt.ID, "Task #" + pt.ID);
                }

                TempData["ViewModelsParamsDictionary"] = paramsDict;
            }
            else
            {
                var paramsDict = (Dictionary<int, string>)TempData["ViewModelsParamsDictionary"];
                paramsDict[4] = testInput;
                paramsDict[5] = testInput + " and testing this too";
                TempData["ViewModelsParamsDictionary"] = paramsDict;
            }

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("ID,Name")] Project project)
        {
            if (ModelState.IsValid)
            {
                // Add the project to the database context
                _context.Add(project);
                await _context.SaveChangesAsync();

                // Create the role corresponding to the project
                AppRole appRole = new AppRole
                {
                    Name = project.Name
                };

                IdentityResult result = await _roleManager.CreateAsync(appRole);
                bool roleCreateSuccess = result.Succeeded;

                // Return to index view or return error if role couldn't be created
                if (roleCreateSuccess)
                {
                    return RedirectToAction(nameof(Index));
                }
               
            }
            return View(project);
        }

        //  

        // GET: Projects/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Project project)
        {
            if (id != project.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ID))
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
            return View(project);
        }

        // GET: Projects/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(e => e.ID == id);
        }
    }
}
