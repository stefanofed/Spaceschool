using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSchool
{
    public class Group
    {
        public int n_students { get; set; }
        public string _name { get; set; }
        public List<Student> _gstudents = new List<Student>();
    }
}
