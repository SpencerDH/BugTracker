using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class DashboardViewModel
    {
        public ICollection<AppUserViewedIssue> RecentlyViewedIssues { get; set; }
    }
}
