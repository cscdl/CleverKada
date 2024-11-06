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
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        public ChangePassword()
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTogglePasswordVisibility1_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword1.Visibility == Visibility.Visible)
            {
                // Hide password
                txtPasswordPlainText1.Text = txtPassword1.Password; // Sync plain text
                txtPassword1.Visibility = Visibility.Collapsed;
                txtPasswordPlainText1.Visibility = Visibility.Visible;
            }
            else
            {
                // Show password
                txtPassword1.Password = txtPasswordPlainText1.Text; // Sync password box
                txtPassword1.Visibility = Visibility.Visible;
                txtPasswordPlainText1.Visibility = Visibility.Collapsed;
            }
        }

        private void btnTogglePasswordVisibility2_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword2.Visibility == Visibility.Visible)
            {
                // Hide password
                txtPasswordPlainText2.Text = txtPassword2.Password; // Sync plain text
                txtPassword2.Visibility = Visibility.Collapsed;
                txtPasswordPlainText2.Visibility = Visibility.Visible;
            }
            else
            {
                // Show password
                txtPassword2.Password = txtPasswordPlainText2.Text; // Sync password box
                txtPassword2.Visibility = Visibility.Visible;
                txtPasswordPlainText2.Visibility = Visibility.Collapsed;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // Show a message box to confirm the cancellation
            MessageBoxResult result = MessageBox.Show("Are you sure you want to cancel the password change?", "Cancel Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {               
                MessageBox.Show("Password change canceled.");

                Login login = new Login();
                login.Show();

                this.Close();
                
            }
        }
    }
}
