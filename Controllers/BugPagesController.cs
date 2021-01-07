using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.Controllers
{
    public class BugPagesController : Controller
    {
        private readonly RaidContext _context;

        public BugPagesController(RaidContext context)
        {
            _context = context;
        }

        // GET: BugPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.BugPages.ToListAsync());
        }

        // GET: BugPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPage = await _context.BugPages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bugPage == null)
            {
                return NotFound();
            }

            return View(bugPage);
        }

        // GET: BugPages/Create
        /*
        public async Task<IActionResult> Create(int projectid)
        {
            var projectName = await _context.Projects
                .FirstOrDefaultAsync(p => p.ID == projectid);

            ViewData["ProjectNameForBugPage"] = projectName;
            return View();
        }
        */
        public IActionResult Create(int projectid)
        {
            ViewBag.projectid = projectid;
            return View();
        }

        // POST: BugPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,Status,Priority,ProjectID")] BugPage bugPage, int projectid)
        {
            // bugPage.ProjectID = projectid;

            if (ModelState.IsValid)
            {
                _context.Add(bugPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bugPage);
        }

        // GET: BugPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPage = await _context.BugPages.FindAsync(id);
            if (bugPage == null)
            {
                return NotFound();
            }
            return View(bugPage);
        }

        // POST: BugPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,Status,Priority")] BugPage bugPage)
        {
            if (id != bugPage.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bugPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugPageExists(bugPage.ID))
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
            return View(bugPage);
        }

        // GET: BugPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bugPage = await _context.BugPages
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bugPage == null)
            {
                return NotFound();
            }

            return View(bugPage);
        }

        // POST: BugPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bugPage = await _context.BugPages.FindAsync(id);
            _context.BugPages.Remove(bugPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugPageExists(int id)
        {
            return _context.BugPages.Any(e => e.ID == id);
        }
    }
}
