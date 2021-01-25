using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Task
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public ICollection<BugPage> BugPages { get; set; }
    }
}
