using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Issue
    {
        // Properties
        [Display(Name = "Ticket Number")]
        public int ID { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int Priority { get; set; }

        [Required]
        public string UserCreated { get; set; }
        public DateTime TimeCreated { get; set; }

        // Navigation properties
        [Display(Name = "Task")]
        public ProjectTask ProjectTask { get; set; }
        public int ProjectTaskID { get; set; }
        public ICollection<IssueComment> IssueComments { get; set; }
        public ICollection<UserIssue> UserIssues { get; set; }

        // Constructor to initialize time created
        public Issue()
        {
            TimeCreated = DateTime.Now;
        }
    }
}
