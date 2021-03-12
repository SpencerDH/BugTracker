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

namespace BugTracker.Controllers
{
    public class IssuesController : Controller
    {
        private readonly RaidContext _context;
        private readonly UserManager<AppUser> _userManager;

        public IssuesController(RaidContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Issues
        public async Task<IActionResult> Index()
        {
            var raidContext = _context.Issues.Include(i => i.ProjectTask);
            return View(await raidContext.ToListAsync());
        }

        // GET: Issues/Details/5
        public async Task<IActionResult> Details(int? id, int commentsPageNumber)
        {

            int pageSize = 5;

            if (id == null)
            {
                return NotFound();
            }

            var issue = await _context.Issues
                .Include(i => i.ProjectTask)
                .Include(i => i.IssueComments)
                .FirstOrDefaultAsync(m => m.ID == id);

            var issueComments = from ic in issue.IssueComments
                                select ic;

            IssueAndCommentsViewModel issueCommentsViewModel = new IssueAndCommentsViewModel()
            {
                issue = issue,
                issueComments = new PaginatedList<IssueComment>(issueComments, commentsPageNumber, pageSize),
                issueComment = new IssueComment()
            };

            return View(issueCommentsViewModel);
        }

        // POST: Issues/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details([Bind("ID,Comment,UserCreated,IssueID")] IssueComment issueComment, int id)
        {
            if (ModelState.IsValid)
            {
                _context.Add(issueComment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Issues", new { id = id });
            }

            return RedirectToAction("Details", "Issues", new { id = id });
        }

        // GET: Issues/Create
        public IActionResult Create(int projecttaskid)
        {
            ViewBag.projecttaskid = projecttaskid;
            // ViewBag.returnUrl = Url.Action("Index", "ProjectTasks", projecttaskid);
            // return View();
            return PartialView("~/Views/Issues/_CreateIssuePartial.cshtml");
        }

        // POST: Issues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Status,Priority,ProjectTaskID,UserCreated")] Issue issue, int projecttaskid)
        {
            if (ModelState.IsValid)
            {
                _context.Add(issue);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "ProjectTasks", new { id = projecttaskid });
                // return RedirectToAction("Details", "ProjectTasks");
            }

            return View(issue);
        }

        // GET: Issues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var issue = await _context.Issues.FindAsync(id);
            if (issue == null)
            {
                return NotFound();
            }
            ViewData["ProjectTaskID"] = new SelectList(_context.ProjectTasks, "ID", "ID", issue.ProjectTaskID);
            return View(issue);
        }

        // POST: Issues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Status,Priority,ProjectTaskID")] Issue issue)
        {
            if (id != issue.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(issue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IssueExists(issue.ID))
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
            ViewData["ProjectTaskID"] = new SelectList(_context.ProjectTasks, "ID", "ID", issue.ProjectTaskID);
            return View(issue);
        }

        // GET: Issues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var issue = await _context.Issues
                .Include(i => i.ProjectTask)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (issue == null)
            {
                return NotFound();
            }

            return View(issue);
        }

        // POST: Issues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var issue = await _context.Issues.FindAsync(id);
            _context.Issues.Remove(issue);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IssueExists(int id)
        {
            return _context.Issues.Any(e => e.ID == id);
        }
    }
}
