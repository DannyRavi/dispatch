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
    /// 

    class DownData
    {
    }

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




            //dgv.Columns[1].Value = "نام مشتری";
            //dgv.Columns[2].Value = "مبلغ";
            //dgv.Columns[3].Value = "تاریخ";
            //dgv.Columns[1].Value = 200;
            //dgv.Rows.Add("five", "six", "seven", "eight", "eight", "eight", "eight", "eight");
            //dgv.Rows.Insert(0, "one", "two", "three", "four");
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.
            //    string a = first_name_;
            ProfileDownload.DownloadPageAsync();
            var items = new List<DataDownload>();
            items.Add(new DataDownload());
        //    items.Add("Spark", 20);
          //  items.Add(new Dog("Fluffy", 4));

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = items;
        }
    }
}
