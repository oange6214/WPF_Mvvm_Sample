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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AttachedPropertiesDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UIElement_Click(object sender, RoutedEventArgs e)
        {
            UIElement element = (UIElement)sender;

            MessageBox.Show("Title of your Control is = " + GetNewName(element), "AttachedProperty");
        }

        #region Attach Property

        public static string GetNewName(DependencyObject obj)
        {
            return (string)obj.GetValue(NewNameProperty);
        }

        public static void SetNewName(DependencyObject obj, string value)
        {
            obj.SetValue(NewNameProperty, value);
        }

        public static readonly DependencyProperty NewNameProperty =
            DependencyProperty.RegisterAttached("NewName", typeof(string), typeof(MainWindow), new PropertyMetadata());

        #endregion


        #region Dependency Property

        public string DpProperty
        {
            get { return (string)GetValue(DpPropertyProperty); }
            set { SetValue(DpPropertyProperty, value); }
        }

        public static readonly DependencyProperty DpPropertyProperty =
            DependencyProperty.Register(nameof(DpProperty), typeof(string), typeof(MainWindow), new PropertyMetadata("預設"));

        #endregion

    }
}
