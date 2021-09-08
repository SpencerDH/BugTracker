using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class AssignUserToIssueGETViewModel
    {
        public int IssueID { get; set; }
        public List<string> AppUserNameList { get; set; }

    }
}
