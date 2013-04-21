using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SpaceSchool;

namespace SpaceSchoolWPF
{
    
    
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Class g_class = new Class();

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //this.RootVisual = new MainPage();
            //this.RootVisual = new TeacherConsole();
        }
    }


}
