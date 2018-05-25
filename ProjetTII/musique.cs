using System;
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
using System.Media;


namespace ProjetTII
{
    public partial class musique : Form
    {
        public SoundPlayer _soundPlayer;
        public musique()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Nicky Jam x J. Balvin - X (EQUIS .mp3");
        }

        private void musique_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("NRJ");
            listBox1.Items.Add("One FM");
            listBox1.Items.Add("RTS Radio La première ");
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void play_Click(object sender, EventArgs e)
        {
           // _soundPlayer.Play();
           string URL = string.Empty;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    URL = "http://cdn.nrjaudio.fm/audio1/fr/30001/mp3_128.mp3?origine=fluxradios";
                    break;
                case 1:
                    URL = "http://onefm.ice.infomaniak.ch/onefm-high.mp3";
                    break;
                case 2:
                    URL = "http://stream.srg-ssr.ch/m/la-1ere/mp3_128";
                    break;

                default:
                    MessageBox.Show("Selectionner une Radio!");
                    break;
            }

           if (!URL.Equals("")) axWindowsMediaPlayer1.URL = URL; 
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //_soundPlayer.Stop();
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
