using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class UserDetailsViewModel
    {
        public IEnumerable<Issue> Issues { get; set; }
        public IEnumerable<IssueComment> IssueComments { get; set; }
        public string currentUserName { get; set; }
    }
}
