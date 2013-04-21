using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceSchool
{
    public partial class TeacherConsole : System.Web.UI.Page
    {
         Class _class = new Class();
            

        protected void Page_Load(object sender, EventArgs e)
        {
            _class.Populate();
            StudentList.DataSource = _class._students;
            
        }
    }
}