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
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();
        }

        private void connection_Load(object sender, EventArgs e)
        {
            label16.Text = "";
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connection_Activated(object sender, EventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            bool v = true;
            try
            {
                Services.con.Open();
                //Services.executeQuery("select * from MARCHESP");
                Services.con.Close();
            }
            catch (Exception ex)
            {
                v = false;
            }
            if (v)
            {
                this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.check;
                label16.Text = "Connexion vérifié";
            }
            else
            {
                this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.multiply;
                label16.Text = "Connexion échoué";
            }
        }
    }
}
