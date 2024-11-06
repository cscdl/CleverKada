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

namespace CleverKada
{
    /// <summary>
    /// Interaction logic for UserSupport3.xaml
    /// </summary>
    public partial class UserSupport3 : Window
    {
        public UserSupport3()
        {
            InitializeComponent();
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeWindow(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            UserSupport2 userSupport2 = new UserSupport2();
            userSupport2.Show();

            this.Close();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            UserSupport4 userSupport4 = new UserSupport4();
            userSupport4.Show();

            this.Close();
        }
    }
}
