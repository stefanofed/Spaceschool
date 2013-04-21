using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceSchool
{
    public class Student
    {
        public long ID { get; set; }
        public string _fullname { get; set; }
        public int age { get; set; }
        public string _country { get; set; }
        public string _city { get; set; }
        public Avatar _avatar { get; set; }
        public long classID { get; set; }
        public Stats _stats { get; set; }
        public List<Role> _roles { get; set; }
    }
}