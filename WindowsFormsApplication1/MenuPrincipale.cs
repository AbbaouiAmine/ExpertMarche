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
    public partial class MenuPrincipale : Form
    {
        public MenuPrincipale()
        {
            InitializeComponent();
        }

        private void MenuPrincipale_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            timeLabel.Text = d.Day.ToString() + " / " + d.Month.ToString() + " / " + d.Year.ToString();
            Services.coloriser(0x0c1a2a, this.arriere_plan);
            Services.coloriser(0x3daba2, this.bt1);
            
            Services.coloriser(0x5c79c5, this.bt2);
            Services.coloriser(0x7e4568, this.bt3);
            Services.coloriser(0xcc6602, this.bt4);
            Services.coloriser(0x96a524, this.bt5);
            Services.coloriser(0xdc9919, this.bt6_1);
            Services.coloriser(0x0868ac, this.bt6_2);
            Services.coloriser(0xde9c14, this.bt7_1);
            Services.coloriser(0x7c4666, this.bt7_2);
            Services.coloriser(0x5f79c6, this.bt8_1);
            Services.coloriser(0x3eaca3, this.bt8_2);
            Services.coloriser(0xcc6602, this.bt9_1);

            Services.coloriser(0x3daba2, this.barbt1);
            Services.coloriser(0x5c79c5, this.barbt2);
            Services.coloriser(0x7e4568, this.barbt3);
            Services.coloriser(0xcc6602, this.barbt4);
            Services.coloriser(0x96a524, this.barbt5);
            Services.coloriser(0xdc9919, this.barbt6_1);
            Services.coloriser(0x0868ac, this.barbt6_2);
            Services.coloriser(0xde9c14, this.barbt7_1);
            Services.coloriser(0x7c4666, this.barbt7_2);
            Services.coloriser(0x5f79c6, this.barbt8_1);
            Services.coloriser(0x3eaca3, this.barbt8_2);
            
            
        }

        

        private void bt1_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0x3daba2, this.barbt1);
        }

        private void bt1_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt1);
        }

        private void bt2_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0x5c79c5, this.barbt2);
        }

        private void bt3_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0x7e4568, this.barbt3);
        }

        private void bt4_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0xcc6602, this.barbt4);
        }

        private void bt5_MouseLeave(object sender, EventArgs e)
        {

            Services.coloriser(0x96a524, this.barbt5);
        }

        private void bt6_1_MouseLeave(object sender, EventArgs e)
        { 
            Services.coloriser(0xdc9919, this.barbt6_1);
        }

        private void bt6_2_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0x0868ac, this.barbt6_2);
        }

        private void bt7_1_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0xde9c14, this.barbt7_1);
        }

        private void bt7_2_MouseLeave(object sender, EventArgs e)
        {
           Services.coloriser(0x7c4666, this.barbt7_2);
        }

        private void bt8_1_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0x5f79c6, this.barbt8_1);
        }

        private void bt8_2_MouseLeave(object sender, EventArgs e)
        {
            Services.coloriser(0x3eaca3, this.barbt8_2);
        }

        private void bt9_1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void bt9_2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void bt2_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt2);
        }

        private void bt3_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt3);
        }

        private void bt4_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt4);
        }

        private void bt5_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt5);
        }

        private void bt6_1_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt6_1);
        }

        private void bt6_2_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt6_2);
        }

        private void bt7_1_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt7_1);
        }

        private void bt7_2_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt7_2);
        }

        private void bt8_1_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt8_1);
        }

        private void bt8_2_MouseEnter(object sender, EventArgs e)
        {
            Services.coloriser(0xffffff, this.barbt8_2);
        }

        private void bt9_1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void bt9_2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        

        private void bt1_Click(object sender, EventArgs e)
        {
            Menu_Mise_a_jour mise = new Menu_Mise_a_jour();
            mise.Show();
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            AttachementG g = new AttachementG();
            g.Show();
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            BordureauEtat b = new BordureauEtat();
            b.Show();
            
            
        }

        private void bt7_1_Click(object sender, EventArgs e)
        {
            connection c = new connection();
            c.Show();
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            OrdreAffiche o = new OrdreAffiche();
            o.Show();
        }

        private void bt6_1_Click(object sender, EventArgs e)
        {
            AttachementEtat et = new AttachementEtat();
            et.Show();
        }

        private void bt6_2_Click(object sender, EventArgs e)
        {
            DecompteEtat de = new DecompteEtat();
            de.Show();
        }

        private void MenuPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bt7_2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void bt8_2_Click(object sender, EventArgs e)
        {
            Aide a = new Aide();
            a.Show();
        }

        private void bt8_1_Click(object sender, EventArgs e)
        {
            A_propos a = new A_propos();
            a.Show();
        }

       
    }
}
