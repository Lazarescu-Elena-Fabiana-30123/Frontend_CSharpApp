﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_SCD
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int departmentID { get; set; }
        public int managerID { get; set; }
        public string email { get; set; }
       // public bool isManager { get; set; }
        public string enrollDate { get; set; }

        public override string ToString() => name;
    }
}
