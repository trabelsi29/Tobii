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

namespace ProjetTII
{
    public partial class Chauff : Form
    {
        public Chauff()
        {
            InitializeComponent();
        }

        private void chauffage_Load(object sender, EventArgs e)
        {
            var url = "http://10.194.69.214:3671/sensors/2/get_temperature";
            var json = new WebClient().DownloadString(url);
            var temp = JsonConvert.DeserializeObject<RootObject>(json);


            double affiche = temp.value;
            label2.Text = "Température :  " + affiche.ToString();
        }
        public class RootObject
        {
            public double value { get; set; }
           

        }
    }
}
