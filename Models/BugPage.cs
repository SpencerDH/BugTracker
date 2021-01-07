using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class BugPage
    {
        // Properties
        [Display(Name = "Ticket Number")]
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public int Priority { get; set; }

        // Navigation properties
        public ICollection<UserBugPage> UserBugPages { get; set; }

        public Project Project { get; set; }
        public int ProjectID { get; set; }
    }
}