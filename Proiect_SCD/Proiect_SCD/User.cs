using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_SCD
{
    class User
    {
        public int id { set; get; }
        public string name { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public DateTime accountCreatedAt { get;}
    }
}
