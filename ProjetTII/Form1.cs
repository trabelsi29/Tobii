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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace ProjetTII

{



    public partial class Form1 : Form
    {

        
        public Form1()
        {
            
            InitializeComponent();


            

            /* String TempActuelle = Temperature("");
             label1.Text = TempActuelle;*/
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

            button1.MouseEnter += new EventHandler(Timer1);
            button2.MouseEnter += new EventHandler(Timer2);
            musique.MouseEnter += new EventHandler(Timer3);
            button1.MouseEnter += new EventHandler(Timer1);
            button1.MouseEnter += new EventHandler(Timer1);
            button1.MouseEnter += new EventHandler(Timer1);
            time.Text = DateTime.Now.ToShortTimeString();
            date.Text = DateTime.Now.ToLongDateString();

            

              var url = "http://10.194.69.214:3671/sensors/2/get_temperature";
              var json = new WebClient().DownloadString(url);
              var temp = JsonConvert.DeserializeObject<RootObject>(json);


              double affiche = temp.value;


            String a = Temperature("");
             label1.Text =a;      

            

            var adr = "http://10.194.69.214:3671/sensors/2/get_all_measures";
            var json2 = new WebClient().DownloadString(adr);
            var hum = JsonConvert.DeserializeObject<RootObject>(json2);

            double humidite = hum.humidity;
            label4.Text = "Humidité :"+ humidite.ToString(); 

       

        }

        Timer chrono = new Timer();


        // Call this procedure when the application starts.  
        // Set to 3 second.  


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
                t = "Température : " + affiche.ToString();

            
            return (t);

        }

        
        private void Button1_Click(object sender, EventArgs e)
        {
            this.chrono.Stop();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
        }

       

        private void Timer1(object sender, EventArgs e)
        {
           
            chrono.Interval = 2000;
            chrono.Start(); // Enable timer.
            chrono.Tick += new EventHandler(Button1_Click);  

        }

        private void Timer2(object sender, EventArgs e)
        {

            chrono.Interval = 2000;
            chrono.Start(); // Enable timer.
            chrono.Tick += new EventHandler(Button2_Click);

        }
        private void Timer3(object sender, EventArgs e)
        {

            chrono.Interval = 2000;
            chrono.Start(); // Enable timer.
            chrono.Tick += new EventHandler(musique_Click);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.chrono.Stop();
            Volets f3 = new Volets();
            f3.Show();
            this.Hide();

        }

        private void musique_Click(object sender, EventArgs e)
        {
            this.chrono.Stop();
            musique m = new musique();
            m.Show();
            this.Hide();
        }


        private void Button6_Click(object sender, EventArgs e)
        {
            this.chrono.Stop();
            TV t = new TV();
            t.Show();
            this.Hide();
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

        

        private void chauffage_Click(object sender, EventArgs e)
        {
            Chauffage ch = new Chauffage();
            ch.Show();
            this.Hide();
        }
    }
}
