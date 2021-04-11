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

namespace BugTracker.Controllers
{
    public class ProjectTasksController : Controller
    {
        private readonly RaidContext _context;

        public ProjectTasksController(RaidContext context)
        {
            _context = context;
        }

        // GET: ProjectTasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectTasks.ToListAsync());
        }

        // GET: ProjectTasks/Details/5
        public async Task<IActionResult> Details(
            int? id,
            int? usersPageNumber,
            int? issuesPageNumber,
            string? issuesSearchTerm)
        {
            // Set page size for both paginated lists
            int pageSize = 5;

            // Get out
            if (id == null)
            {
                return NotFound();
            }

            var projectTask = await _context.ProjectTasks
                .Include(p => p.Issues)
                .Include(p => p.AppUsers)
                .FirstOrDefaultAsync(m => m.ID == id);

            var issues = from issue in projectTask.Issues
                         select issue;

            var appUsers = from appUser in projectTask.AppUsers
                           select appUser;

            if (issuesSearchTerm != null)
            {
                issues = issues.Where(i => i.Name.Contains(issuesSearchTerm) |
                                    i.Description.Contains(issuesSearchTerm));
            }

            if (projectTask == null)
            {
                return NotFound();
            }

            IssueAndUserListsViewModel viewModel = new IssueAndUserListsViewModel()
            {
                projectTask = projectTask,
                issuesList = new PaginatedList<Issue>(issues, issuesPageNumber ?? 1, pageSize),
                usersList = new PaginatedList<AppUser>(appUsers, usersPageNumber ?? 1, pageSize)
            };

            return View(viewModel);
        }

        // GET: ProjectTasks/Create
        public IActionResult Create(int projectid)
        {
            ViewBag.projectid = projectid;
            return View();
        }

        // POST: ProjectTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Summary,Description,ProjectID")] ProjectTask projectTask, int projectid)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectTask);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Projects", new { id = projectid });
            }
            return View(projectTask);
        }

        // GET: ProjectTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectTask = await _context.ProjectTasks.FindAsync(id);
            if (projectTask == null)
            {
                return NotFound();
            }
            return View(projectTask);
        }

        // POST: ProjectTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Summary,Description,ProjectID")] ProjectTask projectTask)
        {
            if (id != projectTask.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectTaskExists(projectTask.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", "Projects", new { id = projectTask.ProjectID });
            }
            return View(projectTask);
        }

        // GET: ProjectTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectTask = await _context.ProjectTasks
                .FirstOrDefaultAsync(m => m.ID == id);
            if (projectTask == null)
            {
                return NotFound();
            }

            return View(projectTask);
        }

        // POST: ProjectTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectTask = await _context.ProjectTasks.FindAsync(id);
            _context.ProjectTasks.Remove(projectTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectTaskExists(int id)
        {
            return _context.ProjectTasks.Any(e => e.ID == id);
        }
    }
}
