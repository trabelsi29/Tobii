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
using WMPLib;


namespace ProjetTII
{
    public partial class musique : Form
    {
       
        WindowsMediaPlayer player =new WindowsMediaPlayer();
        /*public SoundPlayer _soundPlayer;*/
        public musique()
        {
            InitializeComponent();

            


        }

        private void musique_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Booba - DKR");
            listBox1.Items.Add("GHALI - Ricchi Dentro Prod Charlie Charles");
            listBox1.Items.Add("Fat Joe, Remy Ma - All The Way Up ft French Montana");
            listBox1.Items.Add("Nicky Jam x J Balvin - X (EQUIS)");
            listBox1.SelectedIndex = 0;
            /*player.URL = "nicky.mp3";*/
            /* _soundPlayer = new SoundPlayer("Nicky Jam x J. Balvin - X (EQUIS .mp3");*/
           

        }

        Boolean playerON = false;

        private void play_Click(object sender, EventArgs e)
        {
            playerON = true;

            player.controls.play();
            /*_soundPlayer.Play();*/
            string URL = string.Empty;
             switch (listBox1.SelectedIndex)
             {
                case 0:
                    URL = "Booba - DKR.mp3";
                    break;
                    
                 case 1:
                     URL = "ghali.mp3";
                     break;
                 case 2:
                     URL = "alltheway.mp3";
                     break;
                 case 3:
                     URL = "nicky.mp3";
                     break;

                 default:
                    URL = "Booba - DKR.mp3";
                    break;
            }

            if (!URL.Equals("")) axWindowsMediaPlayer1.URL = URL; 
        }

        private void stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            
          // player.controls.stop();
         
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex + 1 < listBox1.Items.Count)
            {
                play_Click(listBox1.SelectedIndex++, e);
           
            }
            else
            {
                listBox1.SelectedIndex = 0;
                
                axWindowsMediaPlayer1.Ctlcontrols.stop();

            }

            
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex !=0)
            {
                play_Click(listBox1.SelectedIndex--, e);

            }
            else
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                axWindowsMediaPlayer1.Ctlcontrols.stop();

            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (playerON == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                playerON = false;
            }
            else {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                playerON = true;
            }

        }

    }
}
