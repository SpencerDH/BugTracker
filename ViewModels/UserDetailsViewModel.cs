using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class UserDetailsViewModel
    {
        public PaginatedList<Issue> Issues { get; set; }
        public PaginatedList<IssueComment> IssueComments { get; set; }
        public int commentsPageNumber { get; set; }
        public int issuesPageNumber { get; set; }
        public string currentUserName { get; set; }
    }
}
