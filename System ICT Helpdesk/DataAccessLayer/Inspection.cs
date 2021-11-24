using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Inspection
    {
        public int InspectionID { get; set; }
        public int VenueID { get; set; }
        public int StaffID { get; set; }
        public string InspectionDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Comment { get; set; }
        public Inspection()
        {

        }
        public Inspection(int inspectID, int venue, int staff, string date, string STime, string ETime, string comment)
        {
            InspectionID = inspectID;
            VenueID = venue;
            StaffID = staff;
            InspectionDate = date;
            StartTime = STime;
            EndTime = ETime;
            Comment = comment;
        }
    }
}
