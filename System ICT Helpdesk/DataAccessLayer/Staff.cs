using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string IDNumber { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string StaffType { get; set; }
        public string Active { get; set; }

        public Staff()
        {

        }
        public Staff(int staffID, string staffNo, string FName, string LName, string userName, string identityNo, string emailAddress, string contactNo, string staffType, string active)
        {
            StaffID = staffID;
            StaffNumber = staffNo;
            FirstName = FName;
            LastName = LName;
            IDNumber = identityNo;
            UserName = userName;
            EmailAddress = emailAddress;
            ContactNo = contactNo;
            StaffType = staffType;
            Active = active;
        }
    }
}
