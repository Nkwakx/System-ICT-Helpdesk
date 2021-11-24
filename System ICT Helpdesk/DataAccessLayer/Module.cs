using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Module
    {
        public int ModuleID { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleDescription { get; set; }
        public int CourseCode { get; set; }
    }
}
