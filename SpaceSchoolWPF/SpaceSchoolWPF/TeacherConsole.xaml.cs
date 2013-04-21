using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SpaceSchool;

namespace SpaceSchoolWPF
{
    /// <summary>
    /// Logica di interazione per TeacherConsole.xaml
    /// </summary>
    public partial class TeacherConsole : Window
    {
        
        
        public TeacherConsole()
        {
            InitializeComponent();
            App.g_class.Populate();
            CompleteList.DataContext = App.g_class._students;

        }

        private void CompleteList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
