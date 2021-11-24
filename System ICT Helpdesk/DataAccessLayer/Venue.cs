using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Venue
    {
        public int VenueID { get; set; }
        public string VenueCode { get; set; }
        public int VenueCapacity { get; set; }
        public int FloorID { get; set; }
        public int BuildingID { get; set; }
    }
}
