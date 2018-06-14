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
using System.Runtime.Serialization.Json;
using System.Net;
using Newtonsoft.Json;
using Tobii.EyeX;
using CurlSharp;
using RestSharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProjetTII
{
    public partial class Chauffage : Form
    {
        public Chauffage()
        {
            InitializeComponent();
        }

        private void boutonAccueil_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Chauffage_Load(object sender, EventArgs e)
        {
            maxmin.Visible = false;

             var url = "http://10.194.69.214:3671/sensors/2/get_temperature";
            var json = new WebClient().DownloadString(url);
            var temp = JsonConvert.DeserializeObject<RootObject>(json);


            double affiche = temp.value;
            tmp.Text = affiche.ToString();
        }
        public class RootObject
        {
            public double value { get; set; }
            public double humidity { get; set; }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            maxmin.Visible = false;
            decimal x = Convert.ToDecimal(tmp.Text);
            SetDegreP(x);
        }
        
       
        public void SetDegreP(decimal valeur)
        {
            if (valeur >= 28 )
            {
                valeur = 28;
                tmp.Text = valeur.ToString();
                maxmin.Visible = true;
                maxmin.Text = "Température  maximale!";
                
            }
            else
            { 
            
                valeur++;
                tmp.Text = valeur.ToString();

            }
            
           
   

        }

        private void moins_Click(object sender, EventArgs e)
        {
            maxmin.Visible = false;
            decimal x = Convert.ToDecimal(tmp.Text);
            SetDegreM(x);
        }
        public void SetDegreM(decimal valeur)
        {
            if (valeur <=18)
            {
                valeur = 18;
                tmp.Text = valeur.ToString();
                maxmin.Visible = true;
                maxmin.Text = "Température  minimale!";

            }
            else
            {

                valeur--;
                tmp.Text = valeur.ToString();

            }




        }

        private void maxmin_Click(object sender, EventArgs e)
        {

        }
    }
}
