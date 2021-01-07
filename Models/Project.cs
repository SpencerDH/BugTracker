using System;
using System.Collections.Generic;

namespace BugTracker.Models
{
    public class Project
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public ICollection<ProjectUser> ProjectUsers { get; set; }
        public ICollection<BugPage> BugPages { get; set; }
    }
}