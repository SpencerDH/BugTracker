using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using BugTracker.Data;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Views.Projects.TaskCardViewComponent
{
    public class TaskCardViewComponent : ViewComponent
    {
        private readonly RaidContext _context;

        public TaskCardViewComponent(RaidContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            // Set page size for all paginated lists
            int pageSize = 5;
            int pageNumber = 1;

            // Query project task object and include associated issues
            var projectTask = await _context.ProjectTasks
                                .Include(pt => pt.Issues)
                                .FirstOrDefaultAsync(pt => pt.ID == id);

            TaskCardViewModel viewModel = new TaskCardViewModel()
            {
                projectTask = projectTask,
                issueList = new PaginatedList<Issue>(projectTask.Issues, pageNumber, pageSize)
            };

            return View(viewModel);
        }
    }
}
