using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class AssignUserToIssuePOSTViewModel
    {
        public int IssueID { get; set; }
        public string AppUserName { get; set; }
    }
}
