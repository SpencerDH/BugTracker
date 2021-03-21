using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class UserIssue
    {
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int IssueID { get; set; }
        public Issue Issue { get; set; }
    }
}
