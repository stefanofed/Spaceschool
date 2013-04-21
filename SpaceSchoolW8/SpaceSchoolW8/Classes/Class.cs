using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceSchool
{
    public class Class
    {
        public long ID { get; set; }
        public long IDSchool { get; set; }
        public int n_students { get; set; }
        public string _name { get; set; }
        public List<Student> _students = new List<Student>();
        public List<Group> _groups = new List<Group>();

        public Class()
        {
        }

        public void Populate()
        {
            _name = "4B";
            
            //Dummy
            _students.Add(new Student() { _fullname = "Jack", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Henry", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Mary", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Phil", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "John", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Lucy", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Nick", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Leo", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Nicole", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Tony", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Eric", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Emma", age = 6, ID = 1, classID = this.ID});
            _students.Add(new Student() { _fullname = "Audrey", age = 6, ID = 1, classID = this.ID });
            _students.Add(new Student() { _fullname = "Melinda", age = 6, ID = 1, classID = this.ID });
            _students.Add(new Student() { _fullname = "Steve", age = 6, ID = 1, classID = this.ID });
            _students.Add(new Student() { _fullname = "Michael", age = 6, ID = 1, classID = this.ID });
            _students.Add(new Student() { _fullname = "Rob", age = 6, ID = 1, classID = this.ID });
            _students.Add(new Student() { _fullname = "Bill", age = 6, ID = 1, classID = this.ID });
            //Add populate from DB
        }



    }
}