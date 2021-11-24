using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InspectionDetails
    {
        public int InspectionDetailsID { get; set; }
        public int InspectionID { get; set; }
        public int EquipmentID { get; set; }
        public int StaffID { get; set; }
        public string InspecDate { get; set; }
        public string FaultComment { get; set; }
        public string Status { get; set; }

        public InspectionDetails()
        {

        }
        public InspectionDetails(int inspDetails, int inspect, int equipmentID, int staffID, string inspectDate, string faultComment, string status)
        {
            InspectionDetailsID = inspDetails;
            InspectionID = inspect;
            EquipmentID = equipmentID;
            StaffID = staffID;
            InspecDate = inspectDate;
            FaultComment = faultComment;
            Status = status;
        }
    }
}
