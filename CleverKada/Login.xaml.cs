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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
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

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            SelectionAccount selectionAccount = new SelectionAccount();
            selectionAccount.Show();

            this.Close();   
        }

        private void btnTogglePasswordVisibility_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Visibility == Visibility.Visible)
            {
                // Hide password
                txtPasswordPlainText.Text = txtPassword.Password; // Sync plain text
                txtPassword.Visibility = Visibility.Collapsed;
                txtPasswordPlainText.Visibility = Visibility.Visible;
            }
            else
            {
                // Show password
                txtPassword.Password = txtPasswordPlainText.Text; // Sync password box
                txtPassword.Visibility = Visibility.Visible;
                txtPasswordPlainText.Visibility = Visibility.Collapsed;
            }
        }

        private void txtForgotPassword_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();

            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            StudentMainDashboard studentMainDashboard = new StudentMainDashboard();
            studentMainDashboard.Show();

            this.Close();

            /*AdminMainDashboard adminMainDashboard = new AdminMainDashboard();
            adminMainDashboard.Show();

            this.Close();*/
        }
    }
}
