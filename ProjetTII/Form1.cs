using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeXFramework;
//using Tobii.EyeX.Framework;
using System.Runtime.Serialization.Json;
using System.Net;
using Newtonsoft.Json;
using Tobii.EyeX;
using CurlSharp;
using RestSharp;


namespace ProjetTII

{
   


        public partial class Form1 : Form
    {
       

        public Form1()
        {
          
            InitializeComponent();
            String TempActuelle = Temperature("");
            label1.Text = TempActuelle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            time.Text = DateTime.Now.ToShortTimeString();
            date.Text = DateTime.Now.ToLongDateString();


            /*

              var url = "http://10.194.69.214:3671/sensors/2/get_temperature";
              var json = new WebClient().DownloadString(url);
              var temp = JsonConvert.DeserializeObject<RootObject>(json);


              double affiche = temp.value;*/


            /*String a = Temperature("");
             label1.Text =a;      */



            var adr = "http://10.194.69.214:3671/sensors/2/get_all_measures";
            var json2 = new WebClient().DownloadString(adr);
            var hum = JsonConvert.DeserializeObject<RootObject>(json2);

            double humidite = hum.humidity;
            label4.Text = "Humidité : 17.2"+ humidite.ToString();

       

        }
        public class RootObject
        {
            public double value { get; set; }
            public double humidity { get; set; }

        }

         public String Temperature(String t)
        {
            
            var url = "http://10.194.69.214:3671/sensors/2/get_temperature";
            var json = new WebClient().DownloadString(url);
            var temp = JsonConvert.DeserializeObject<RootObject>(json);


            double affiche = temp.value;

            if (affiche < 0)
            {
                t = "Consultation impossible";

            }
            else
                t = "Température : 23.4 " + affiche.ToString();

            
            return (t);

        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2  f2 = new Form2();
            f2.Show();
            this.Hide();
                      

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Volets f3 = new Volets();
            f3.Show();
            this.Hide();

        }
        
        
        
        private void Button6_Click(object sender, EventArgs e)
        {
            /*Button senderButton = (Button)sender;
            senderButton.Text = "";
            m_statusB3.Text = "Les volets sont fermés ";*/
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {
            
          
        }

              

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

       

       

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void musique_Click(object sender, EventArgs e)
        {
            musique m = new musique();
            m.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void porte_Click(object sender, EventArgs e)
        {
            porte f5 = new porte();
            f5.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void appel_Click(object sender, EventArgs e)
        {
            telephone f6 = new telephone();
            f6.Show();
            this.Hide();
        }
    }
}
