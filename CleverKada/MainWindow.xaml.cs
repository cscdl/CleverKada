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
using System.Windows.Threading;

namespace CleverKada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            StartLoadingBar();
        }

        private void StartLoadingBar()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10); // Adjust the speed as desired
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (LoadingBar.Value < 100)
            {
                LoadingBar.Value += 1;
            }
            else
            {
                timer.Stop();
                OpenSecondWindow();
            }
        }

        private void OpenSecondWindow()
        {
            // Show the second window
            UserSupport1 userSupport1 = new UserSupport1();
            userSupport1.Show();
            this.Close(); // Close the main window if desired
        }
    }
}
