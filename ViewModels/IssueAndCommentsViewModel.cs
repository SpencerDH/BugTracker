using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class IssueAndCommentsViewModel
    {
        public Issue issue { get; set; }
        public IEnumerable<IssueComment> issueComments { get; set; }
    }
}
