using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class AppUserViewedIssue
    {
        public int ID { get; set; }
        public Issue Issue { get; set; }
        public DateTime TimeViewed { get; set; }
        public AppUser AppUser { get; set; }

        public AppUserViewedIssue()
        {
            TimeViewed = DateTime.Now;
        }
    }
}
