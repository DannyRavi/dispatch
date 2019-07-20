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
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DisPatch
{
    /// <summary>
    /// Interaction logic for Data.xaml
    /// </summary>
    /// 


    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public string Sex { get; set; }
        public string Age { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string group { get; set; }

    }

    public partial class Data : Window
    {
        Timer timer = new Timer(1000);

        public static dynamic first_name_ { get; private set; }
        public static dynamic last_name_ { get; private set; }
        public static dynamic phone_number_ { get; private set; }
        public static dynamic mobile_number_ { get; private set; }
        public static dynamic age_ { get; private set; }
        public static dynamic group_ { get; private set; }
        public static dynamic nation_code_ { get; private set; }
        public static dynamic height_ { get; private set; }
        public static dynamic weigth_ { get; private set; }
        public static dynamic address_ { get; private set; }
        public static dynamic postal_code_ { get; private set; }
        public static dynamic email_ { get; private set; }
        public static dynamic gender_ { get; private set; }
        public static dynamic user_ { get; private set; }

        public Data()
        {
            InitializeComponent();

            time2TextBox.Text = "ساعت: " + DateTime.Now.ToString("HH:mm:ss");//"HH:mm:ss"
            date2TextBox.Text = DateTime.Now.ToString("D");//"HH:mm:ss"
                                                          // timeTextBox.Text = DateTime.Now.ToString("yyyy/MM/dd");
            timer.Start();


            netCon();

            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Id = user_ , Name = first_name_ , Family = last_name_
            , Sex = gender_ , Age = age_ , Phonenumber = phone_number_ , Address = address_,
            group = group_});
          //  users.Add(new User() { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17) });
           // users.Add(new User() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2) });

            dgUsers.ItemsSource = users;


        }




        public static void netCon()
        {


            string URL = "https://dannyraviii.pythonanywhere.com/bip/profile/1/";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.ContentType = "application/json; charset=utf-8";
            request.Headers["Authorization"] = "Token 5e95ee2a97d212e9080d7079149073b1a2ae4d7b";
            request.PreAuthenticate = true;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                //  Console.WriteLine(reader.ReadToEnd());
                //      var toner = JsonConvert.DeserializeObject<DataDownload>(reader.ReadToEnd());

                string json = string.Empty;

                json = reader.ReadToEnd();

           
                DataDownload dd = new DataDownload();


                var res = JsonConvert.DeserializeObject<dynamic>(json);
               
                first_name_ = res.first_name;
                last_name_ = res.last_name;
                phone_number_ = res.phone_number;
                mobile_number_ = res.mobile_number;
                age_ = res.age;
                group_ = res.group;
                nation_code_ = res.nation_code;
                height_ = res.height;
                weigth_ = res.weigth;
                address_ = res.address;
                postal_code_ = res.postal_code;
                email_ = res.email;
                gender_ = res.gender;
                user_ = res.user;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            netCon();


            //  dgUsers.Remove(1);

            dgUsers.ItemsSource = "";


            List<User> orgent = new List<User>();
            orgent.Add(new User()
            {
                Id = user_,
                Name = first_name_,
                Family = last_name_
            ,
                Sex = gender_,
                Age = age_,
                Phonenumber = phone_number_,
                Address = address_,
                group = group_
            });

            orGent.ItemsSource = orgent;
        }


    }


}
