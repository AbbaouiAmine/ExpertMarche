using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Principale : Form
    {
        private int ctr;
        public Principale()
        {
            InitializeComponent();
        }

        private void Principale_Load(object sender, EventArgs e)
        {
            Color temp = Color.FromArgb(0x000);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);
            this.BackColor = result;
            ctr = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ctr++;
            if (ctr == 20)
            {
                timer1.Stop();
                MenuPrincipale m = new MenuPrincipale();
                m.Show();
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
