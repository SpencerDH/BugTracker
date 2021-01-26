using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ProjectTask
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public int ProjectID { get; set; }
        public ICollection<BugPage> BugPages { get; set; }
    }
}
