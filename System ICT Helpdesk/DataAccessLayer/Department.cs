using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepName { get; set; }
        public int BuildingID { get; set; }
        public string DepContactNumber { get; set; }
        public string DepEmailAddress { get; set; }

        public Department()
        {

        }
        public Department(int depID, string depName, int build, string depNo, string depEmail)
        {
            DepartmentID = depID;
            DepName = depName;
            BuildingID = build;
            DepContactNumber = depNo;
            DepEmailAddress = depEmail;
        }
    }
}
