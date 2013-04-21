using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceSchool
{
    public class Mission
    {
        long _ID;
        string _name;
        string _description;
        Level _level = new Level();
        Class _class = new Class();
        List<Component> _components = new List<Component>();
        List<Student> _students = new List<Student>();
        List<Role> _roles = new List<Role>();
        List<Goal> _goals = new List<Goal>();
        int _score;
    }
}