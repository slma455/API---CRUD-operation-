using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDAY2.Models
{
    public class StudentGet
    {

        public int id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? address { get; set; }
        public string? supervisor { get; set; }
        public int age { get; set; }
        public string? deptname { get; set; }
    }
}
