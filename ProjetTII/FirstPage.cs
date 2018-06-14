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
using Tobii.EyeX.Framework;
using System.Runtime.Serialization.Json;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using WpfAnimatedGif.Decoding;
using System.Speech;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
//using Tobii.Gaming;

namespace ProjetTII
{
    public partial class FirstPage : Form
    {

        public SpeechSynthesizer parole = new SpeechSynthesizer();

        public FirstPage()
        {
            InitializeComponent();
            
        }

        public bool Verifvoix(string voix)
        {
            foreach (InstalledVoice unevoix in parole.GetInstalledVoices()) // Je liste les voix installées
            {
                if (unevoix.VoiceInfo.Name == voix) // Je vérifie ici que la voix est égale à celle de la variable voix
                    return true; // Si la voix correspond bien alors la fonction retourne true
            }
            return false; // Je renvoi la valeur false si la voix ne correspond pas
        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            button1.MouseEnter += new EventHandler(Timer1);


            if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
            {
                salvator.Text = "Bonjour Salvatore ! ";

            }
            else
            {
                salvator.Text = "Bonsoir  Salvatore ! ";
            }
            SpeechSynthesizer parole = new SpeechSynthesizer();
            string voix = "ScanSoft Virginie_Dri40_16kHz";
            if (Verifvoix(voix)) // Si la voix est installée
                parole.SelectVoice(voix); // Alors on l'utilise

            parole.SpeakAsync(salvator.Text);

        }
        Timer chrono = new Timer();

        private void Timer1(object sender, EventArgs e)
        {

            chrono.Interval = 3000;
            chrono.Start(); // Enable timer.
            chrono.Tick += new EventHandler(button1_Click);

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.chrono.Stop();
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salvator_Click(object sender, EventArgs e)
        {

        }
    }
}
