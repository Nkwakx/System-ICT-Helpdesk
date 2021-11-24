using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string IDNumber { get; set; }
        public string StudentEmailAddress { get; set; }
        public string StudentContactNo { get; set; }
        public int CourseCode { get; set; }
        public Student()
        {

        }
        public Student(int studID, string StudNumber, string studName, string studSurname, string studIDNumber, string studEmail, string studContact, int courseCode)
        {
            StudentID = studID;
            StudentNumber = StudNumber;
            StudentName = studName;
            StudentSurname = studSurname;
            IDNumber = studIDNumber;
            StudentEmailAddress = studEmail;
            StudentContactNo = studContact;
            CourseCode = courseCode;
        }
    }
}
