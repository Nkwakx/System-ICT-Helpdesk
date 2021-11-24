using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EquipmentType
    {
        public int EquipmentTypeID { get; set; }
        public string EquipmentTypeName { get; set; }
        public EquipmentType()
        {

        }
        public EquipmentType(int equipType, string equipTypName)
        {
            EquipmentTypeID = equipType;
            EquipmentTypeName = equipTypName;
        }
    }
}
