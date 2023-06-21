using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDAY2.Models
{
    public class StudentAdd
    {
        public int id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? address { get; set; }
        public int age { get; set; }
        public int dept_id { get; set; }
        public int super_id { get; set; }

      
    }
}
