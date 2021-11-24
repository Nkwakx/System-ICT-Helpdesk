using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public string Barcode { get; set; }
        public string EquipmentDescription { get; set; }
        public string DateRecieved { get; set; }
        public int EquipmentTypeID { get; set; }
        public int VenueID { get; set; }
        public string EquipmentStatus { get; set; }
        public int YearsValid { get; set; }
        public Equipment()
        {

        }
    }
}
