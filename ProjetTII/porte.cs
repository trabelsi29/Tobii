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
    public partial class porte : Form
    {
        public porte()
        {
            InitializeComponent();
            
        }

        private void accueil_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void ouvrir_Click(object sender, EventArgs e)
        {
            statut_porte.Text = "Porte ouverte! ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statut_porte.Text = "Porte fermée! ";
        }
    }
}
