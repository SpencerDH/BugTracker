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

        [Required]
        [StringLength(60)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int Priority { get; set; }
        public string Date { get; set; }

        // Navigation properties
        public ProjectTask ProjectTask { get; set; }
        public int ProjectTaskID { get; set; }
        public ICollection<IssueComment> IssueComments { get; set; }
    }
}
