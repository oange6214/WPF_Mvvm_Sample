using System.Windows;
using WPFDataGrid.Models;

namespace WPFDataGrid
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            myDataGrid.ItemsSource = Student.GetStudents(); 
        }
    }
}
