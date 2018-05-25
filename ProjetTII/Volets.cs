using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetTII
{
    public partial class Volets : Form
    {
        public Volets()
        {
            InitializeComponent();
        }

        

        private void ouvrir_Click(object sender, EventArgs e)
        {
             Button senderButton = (Button)sender;
            
              statut.Text = "Volets ouverts ! ";
        }
        private void fermer_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            statut.Text = "Volets fermés ! ";

        }

        private void statut_Click(object sender, EventArgs e)
        {

        }

        private void accueil_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
