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
    public partial class TV : Form
    {
        public TV()
        {
            
            InitializeComponent();
            
        }

        private void TV_Load(object sender, EventArgs e)
        {
            volume.Text = "0";
            statut.Text = "Télévision éteinte";
            listBox1.Visible = false;
            listBox1.Items.Add("TF1");
            listBox1.Items.Add("RTS1");
            listBox1.Items.Add("RTS2");
            listBox1.Items.Add("Canal +");

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

        private void arret_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == false)
            {
                listBox1.Visible = true;
                statut.Text = "Télévision allumée";
            }
            else
            {
                listBox1.Visible = false;
                statut.Text = "Télévision éteinte";
            }

        }

        private void volume_Click(object sender, EventArgs e)
        {

        }

        private void muet_Click(object sender, EventArgs e)
        {
            volume.Text = "0";

        }

        private void PlusV_Click(object sender, EventArgs e)
        {
            if (volume.Text == "0")
            {
                volume.Text = "25";

            }
            else if (volume.Text == "25")
            {
                volume.Text = "50";

            }
            else if (volume.Text == "50")
            {
                volume.Text = "75";

            }
            else if (volume.Text == "75")
            {
                volume.Text = "100";

            }
            else volume.Text = "Max !";
        }

        private void MoinsV_Click(object sender, EventArgs e)
        {
            if (volume.Text == "100" || volume.Text=="Max !"    )
            {
                volume.Text = "75";

            }
            else if (volume.Text == "75")
            {
                volume.Text = "50";

            }
            else if (volume.Text == "50")
            {
                volume.Text = "25";

            }
            else if (volume.Text == "25")
            {
                volume.Text = "0";

            }
            else volume.Text = "0";
        }

        private void PlusCh_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex + 1 < listBox1.Items.Count)
            {
                listBox1.SelectedIndex++;

            }
           
        }

        private void MoinsCH_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >0)
            {
                listBox1.SelectedIndex--;

            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            chaine.Text = "Chaine : " + listBox1.SelectedItem;
        }
    }
}
