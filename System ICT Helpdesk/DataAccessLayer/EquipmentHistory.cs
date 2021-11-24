using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EquipmentHistory
    {
        public int EquipmentHistoryID { get; set; }
        public string EquipHistoryDate { get; set; }
        public string HistoryDescription { get; set; }
        public string EquipmentStatus { get; set; }
        public int EquipmentID { get; set; }
    }
}
