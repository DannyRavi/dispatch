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
using System.Globalization;
using System.Timers;

namespace DisPatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer = new Timer(1000);
        public MainWindow()
        {
            InitializeComponent();

            timeTextBox.Text = "ساعت: " + DateTime.Now.ToString("HH:mm:ss");//"HH:mm:ss"
            dateTextBox.Text = DateTime.Now.ToString("D");//"HH:mm:ss"
                                                                 // timeTextBox.Text = DateTime.Now.ToString("yyyy/MM/dd");
            timer.Start();
        }

        private void login(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text.Equals("danny") && PasswordTextBox.Password.Equals("test"))
            {

                Data data = new Data();
                this.Visibility = Visibility.Hidden;
                data.Show();
              //  new Data().ShowDialog();
              //  this.Close();
                
                

            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز ورود اشتباه است");
               
            }
        }
  



    }
}
