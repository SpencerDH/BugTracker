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
    public class IssuesController : Controller
    {
        private readonly RaidContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public IssuesController(RaidContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
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
                .Include(i => i.UserIssues)
                    .ThenInclude(ui => ui.AppUser)
                        // .ThenInclude(u => u.UserName)
                .Include(i => i.IssueComments)
                    .ThenInclude(ic => ic.AppUser)
                        // .Where(au != null)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (issue.Status == "Closed")
            {
                //
            }

            // Get variables for the viewmodel
            var projectTaskName = issue.ProjectTask.Name;
            var issueComments = from ic in issue.IssueComments
                                select ic;

            var currentProjectID = issue.ProjectTask.ProjectID;
            var currentProject = await _context.Projects
                .FirstOrDefaultAsync(p => p.ID == currentProjectID);

            // Create the viewmodel
            IssueAndCommentsViewModel issueCommentsViewModel = new IssueAndCommentsViewModel()
            {
                projectName = currentProject.Name,
                projectID = currentProjectID,
                projectTaskID = issue.ProjectTaskID,
                projectTaskName = projectTaskName,
                issue = issue,
                issueComments = new PaginatedList<IssueComment>(issue.IssueComments, commentsPageNumber, pageSize),
                issueComment = new IssueComment()
            };

            return View(issueCommentsViewModel);
        }

        // POST: Issues/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details([Bind("ID,Comment,UserCreated,IssueID")] IssueComment issueComment, int id)
        {
            // Check to see if issue is closed; if it is, then return view
            var issue = await _context.Issues
                .FirstOrDefaultAsync(i => i.ID == id);

            if (issue.Status == "Closed")
            {
                // Probably should perform some action here to show the user that the action cannot be completed.
                // Or maybe handle that in the view; I'm not sure.
                return RedirectToAction("Details", "Issues", new { id = id });
            }

            if (ModelState.IsValid)
            {
                // Add AppUser property
                var currentUser = await _userManager.GetUserAsync(User);
                issueComment.AppUser = currentUser;

                // Save new issueComment
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
                // Get current user ID
                var currentUserName = User.Identity.Name;
                var currentUser = await _userManager.FindByNameAsync(currentUserName);

                // Initialize userIssue
                var userIssue = new UserIssue
                {
                    IssueID = issue.ID,
                    AppUserID = currentUser.Id
                };

                // Add the new issue to the database
                issue.UserIssues = new List<UserIssue>
                {
                    userIssue
                };

                _context.Add(issue);
                await _context.SaveChangesAsync();

                

                /*
                var currentIssue = await _context.Issues
                    .Include(i => i.UserIssues)
                    .FirstOrDefaultAsync(i => i.ID == issue.ID);

                currentIssue.UserIssues.Add(userIssue);
                */

                return RedirectToAction("Details", "ProjectTasks", new { id = projecttaskid });

                // The current challenge is to figure out how to add a new userIssue to the ICollections navigation property
                // for UserIssues without overwriting the current value for that property.

                /*
                // Create the new role associated with the issue
                string issueRoleName = issue.Name + "_Role";
                AppRole issueRole = new AppRole
                {
                    Name = issueRoleName
                };

                IdentityResult result = await _roleManager.CreateAsync(issueRole);
                bool roleCreateSuccess = result.Succeeded;

                if (roleCreateSuccess)
                {
                    // Add the user who created the issue to the role automatically
                    var currentUserName = User.Identity.Name;
                    var currentUser = await _userManager.FindByNameAsync(currentUserName);
                    var addingUserToRole = await _userManager.AddToRoleAsync(currentUser, issueRoleName);

                    // Return to the tasks page
                    return RedirectToAction("Details", "ProjectTasks", new { id = projecttaskid });
                }  
                */
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

        // POST: Issues/Close/5
        public async Task<IActionResult> Close(int id)
        {
            var issue = await _context.Issues
                .FirstOrDefaultAsync(m => m.ID == id);

            issue.Status = "Closed";
            if (ModelState.IsValid)
            {
                _context.Update(issue);
                await _context.SaveChangesAsync();
            }

            /*
            var issueName = issue.Name;
            var issueRole = await _roleManager.FindByNameAsync(issueName + "_Role");
            var resultFromDeleteRole = await _roleManager.DeleteAsync(issueRole);
            */

            return RedirectToAction("Details", "Issues", new { id = id });
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

        // GET: Assign user to issue
        public async Task<IActionResult> AssignUserToIssue(int IssueID)
        {
            // Create ViewModel for the GET user-to-issue assignment
            var userNamesList = await _context.AppUsers
                .Select(au => au.UserName)
                .ToListAsync();

            AssignUserToIssueGETViewModel viewModel = new AssignUserToIssueGETViewModel
            {
                IssueID = IssueID,
                AppUserNameList = userNamesList
            };

            // Return the ViewModel to the partial view for assigning user to issue
            return PartialView("~/Views/Issues/_AssignUserToIssuePartial.cshtml", viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AssignUserToIssue(AssignUserToIssuePOSTViewModel viewModel)
        {
            // Normalized username
            string normalizedUserName = viewModel.AppUserName.ToUpper().Normalize();

            // Get the user to whom the issue should be assigned
            var userToAssign = await _userManager
                .FindByNameAsync(normalizedUserName);

            // Get issue corresponding to the ID
            var issue = await _context
                .Issues
                .Include(i => i.UserIssues)
                .FirstOrDefaultAsync(i => i.ID == viewModel.IssueID);

            // Initialize userIssue
            var userIssue = new UserIssue
            {
                IssueID = issue.ID,
                AppUserID = userToAssign.Id
            };

            // Add the user issue
            issue.UserIssues.Add(userIssue);
            _context.Update(issue);

            await _context.SaveChangesAsync();

            return View(issue);
        }

        private bool IssueExists(int id)
        {
            return _context.Issues.Any(e => e.ID == id);
        }
    }
}
