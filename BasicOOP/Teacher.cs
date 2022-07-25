using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Teacher : Person // inheritance 
    {
        public string facultyNo { get; set; }
        public string department { get; set; }
        public double salary { get; set; }
    }
}
