using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Tutor
    {
        public int TutorID { get; set; }
        public int RequestID { get; set; }
        public int ModuleID { get; set; }
        public int VenueID { get; set; }
        public string TutorDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
