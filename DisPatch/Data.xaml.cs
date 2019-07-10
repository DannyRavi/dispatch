using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DisPatch
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Window
    {
        Timer timer = new Timer(1000);
        public Data()
        {
            InitializeComponent();

            time2TextBox.Text = "ساعت: " + DateTime.Now.ToString("HH:mm:ss");//"HH:mm:ss"
            date2TextBox.Text = DateTime.Now.ToString("D");//"HH:mm:ss"
                                                          // timeTextBox.Text = DateTime.Now.ToString("yyyy/MM/dd");
            timer.Start();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
