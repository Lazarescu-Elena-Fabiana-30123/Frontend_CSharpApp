using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_SCD
{
    class Department
    {
        public int departmentID { get; set; }
        public string description { get; set; }
        public int parentID { get; set; }
        public int managerID { get; set; }
        public override string ToString() => description;
    }
}
