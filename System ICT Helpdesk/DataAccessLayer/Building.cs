using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Building
    {
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }
        public Building()
        {

        }
        public Building(int build, string BuildName)
        {
            BuildingID = build;
            BuildingName = BuildName;
        }
    }
}
