using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Request
    {
        public int RequestID { get; set; }
        public string RequestDescription { get; set; }
        public int StaffID { get; set; }
        public int StudentID { get; set; }
        public int TaskID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string RequestStatus { get; set; }
        public string StaffAssigned { get; set; }
    }
}
