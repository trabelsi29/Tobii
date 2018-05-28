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
using System.IO;
using System.Threading;
using System.Timers;
using Newtonsoft.Json.Linq;
using System.Speech;
using System.Speech.Synthesis;


namespace ProjetTII
{
    public partial class Form2 : Form
    {


        public SpeechSynthesizer parole = new SpeechSynthesizer();

        public Form2()
        {
            InitializeComponent();
            /* timer.Interval = 1000; //si non défini auparavant
             timer.Enabled = true;*/
            SpeechSynthesizer parole = new SpeechSynthesizer();
           


        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
           /* var url = "http://10.194.69.214:3671/dimmers/set_level";
            var json = new WebClient().DownloadString(url);
            var lum = JsonConvert.DeserializeObject<RootObject>(json);
            double val = lum.value;
            double node = lum.node_id;*/

            // statut_lumiere.Text = val.ToString();
           

        }
        public class RootObject
        {
            public double node_id { get; set; }
            public double value { get; set; }

            
   

        }

        /* private void t_Tick(object sender, EventArgs e)
         {
             if (toggleLight)
             {
                 button1.BackColor = Color.Green;
                 toggleLight = false;
             }
             else
             {
                 button1.BackColor = Color.LightGray;
                 toggleLight = true;
             }
         }
         private void t_Tick2(object sender, EventArgs e)
         {
             if (toggleLight2)
             {
                 button3.BackColor = Color.Green;
                 toggleLight2 = false;
             }
             else
             {
                 button3.BackColor = Color.LightGray;
                 toggleLight2 = true;
             }
         }*/
        public bool verifvoix(string voix)
        {
            foreach (InstalledVoice unevoix in parole.GetInstalledVoices()) // Je liste les voix installées
            {
                if (unevoix.VoiceInfo.Name == voix) // Je vérifie ici que la voix est égale à celle de la variable voix
                    return true; // Si la voix correspond bien alors la fonction retourne true
            }
            return false; // Je renvoi la valeur false si la voix ne correspond pas
        }


        private void button1_Click(object sender, EventArgs e)
        { /*
            // Open request and set post data
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://10.194.69.214:3671/dimmers/set_level");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postData = "{ \"node_id\": \"3\", \"value\": \"100\" }";

            // Set postData to byte type and set content length
            byte[] postBytes = System.Text.UTF8Encoding.UTF8.GetBytes(postData);
            request.ContentLength = postBytes.Length;

            // Write postBytes to request stream
            Stream s = request.GetRequestStream();
            s.Write(postBytes, 0, postBytes.Length);
            s.Close();

            // Get the reponse
            WebResponse response = request.GetResponse();

            // Status for debugging
            // Status for debugging
            string ResponseStatus = (((HttpWebResponse)response).StatusDescription);

            // Get the content from server and read it from the stream
            s = response.GetResponseStream();
            StreamReader reader = new StreamReader(s);
            string responseFromServer = reader.ReadToEnd();*/
            string voix = "ScanSoft Virginie_Dri40_16kHz";
            if (verifvoix(voix)) // Si la voix est installée
                parole.SelectVoice(voix); // Alors on l'utilise

            parole.SpeakAsync(champtexte1.Text);
           // parole.SelectVoice("Microsoft Server Speech Text to Speech Voice (fr-FR, Hortense)");

          
            statut_lumiere.Text = "Lumière allumée ! ";
        }
       /* public class RootObject
        {
            public double node_id { get; set; }
            public double value { get; set; }

        }*/

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://10.194.69.214:3671/dimmers/set_level");
            request.Method = "POST";
            request.ContentType = "application/json";
            string postData = "{ \"node_id\": \"3\", \"value\": \"0\" }";

            // Set postData to byte type and set content length
            byte[] postBytes = System.Text.UTF8Encoding.UTF8.GetBytes(postData);
            request.ContentLength = postBytes.Length;

            // Write postBytes to request stream
            Stream s = request.GetRequestStream();
            s.Write(postBytes, 0, postBytes.Length);
            s.Close();

            // Get the reponse
            WebResponse response = request.GetResponse();

            // Status for debugging
            string ResponseStatus = (((HttpWebResponse)response).StatusDescription);

            // Get the content from server and read it from the stream
            s = response.GetResponseStream();
            StreamReader reader = new StreamReader(s);
            string responseFromServer = reader.ReadToEnd();


         
            */
            string voix = "ScanSoft Virginie_Dri40_16kHz";
            if (verifvoix(voix)) // Si la voix est installée
                parole.SelectVoice(voix); // Alors on l'utilise

            parole.SpeakAsync(champtexte2.Text);

            statut_lumiere.Text = "Lumière éteinte !";
            
           
        }
    

        private void m_statusB2_Click(object sender, EventArgs e)
        {

        }

        private void m_statusB1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
