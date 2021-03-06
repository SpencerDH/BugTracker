using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;

namespace BugTracker.Models
{
    public class IssueComment
    {
        // Properties
        public int ID { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public int IssueID { get; set; }
        public Issue Issue { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

        // Constructor to get created date
        public IssueComment()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
