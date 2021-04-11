using System;
using System.Collections.Generic;

namespace BugTracker.Models
{
    public class Project
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }

        // Navigation properties
        public ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}