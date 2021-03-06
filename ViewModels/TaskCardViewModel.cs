using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class TaskCardViewModel
    {
        public ProjectTask projectTask { get; set; }
        public PaginatedList<Issue> issueList { get; set; }
    }
}
