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
    public partial class Menu_Mise_a_jour : Form
    {
        public Menu_Mise_a_jour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Mise_a_jour_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            timeLabel.Text = d.Day.ToString() + " / " + d.Month.ToString() + " / " + d.Year.ToString();

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Mise_a_jour_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            Directeur_Mise d = new Directeur_Mise();
            d.MdiParent = this;
            d.Show();
            this.panel2.Visible = false;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            Direction_Mise d = new Direction_Mise();
            d.MdiParent = this;
            d.Show();
            this.panel2.Visible = false;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            Diriger_Mise d = new Diriger_Mise();
            d.MdiParent = this;
            d.Show();
            this.panel2.Visible = false;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            Ordonnanceur_Mise o = new Ordonnanceur_Mise();
            o.MdiParent = this;
            o.Show();
            this.panel2.Visible = false;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            Ordre_Service_Mise os = new Ordre_Service_Mise();
            os.MdiParent = this;
            os.Show();
            this.panel2.Visible = false;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Prestataire_Mise p = new Prestataire_Mise();
            p.MdiParent = this;
            p.Show();
            this.panel2.Visible = false;
            
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            MarchésP_Mise p = new MarchésP_Mise();
            p.MdiParent = this;
            p.Show();
            this.panel2.Visible = false;
        }

        private void bt1_MouseEnter(object sender, EventArgs e)
        {
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label4.ForeColor = System.Drawing.Color.White;
        }

        private void bt2_MouseEnter(object sender, EventArgs e)
        {
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label1.ForeColor = System.Drawing.Color.White;
        }

        private void bt3_MouseEnter(object sender, EventArgs e)
        {
            this.bt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label2.ForeColor = System.Drawing.Color.White;
        }

        private void bt4_MouseEnter(object sender, EventArgs e)
        {
            this.bt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label3.ForeColor = System.Drawing.Color.White;
        }

        private void bt5_MouseEnter(object sender, EventArgs e)
        {
            this.bt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label5.ForeColor = System.Drawing.Color.White;
        }

        private void bt6_MouseEnter(object sender, EventArgs e)
        {
            this.bt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label10.ForeColor = System.Drawing.Color.White;
        }

       

        private void bt7_MouseEnter(object sender, EventArgs e)
        {
            this.bt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label8.ForeColor = System.Drawing.Color.White;
        }

        private void bt8_MouseEnter(object sender, EventArgs e)
        {
            this.bt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label6.ForeColor = System.Drawing.Color.White;
        }

        private void bt9_MouseEnter(object sender, EventArgs e)
        {
            this.bt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label7.ForeColor = System.Drawing.Color.White;
        }

        private void bt10_MouseEnter(object sender, EventArgs e)
        {
            this.bt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label9.ForeColor = System.Drawing.Color.White;
        }

       

        private void bt11_MouseEnter(object sender, EventArgs e)
        {
            this.bt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label11.ForeColor = System.Drawing.Color.White;
        }

        private void bt16_MouseEnter(object sender, EventArgs e)
        {
            this.bt16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label13.ForeColor = System.Drawing.Color.White;
        }

        private void bt13_MouseEnter(object sender, EventArgs e)
        {
            this.bt13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label12.ForeColor = System.Drawing.Color.White;
        }

        private void bt17_MouseEnter(object sender, EventArgs e)
        {
            this.bt17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(114)))), ((int)(((byte)(241)))));
            this.label14.ForeColor = System.Drawing.Color.White;
        }

        private void bt1_MouseLeave(object sender, EventArgs e)
        {
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt2_MouseLeave(object sender, EventArgs e)
        {
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt3_MouseLeave(object sender, EventArgs e)
        {
            this.bt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt4_MouseLeave(object sender, EventArgs e)
        {
            this.bt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt5_MouseLeave(object sender, EventArgs e)
        {
            this.bt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt6_MouseLeave(object sender, EventArgs e)
        {
            this.bt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt8_MouseLeave(object sender, EventArgs e)
        {
            this.bt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt9_MouseLeave(object sender, EventArgs e)
        {
            this.bt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt10_MouseLeave(object sender, EventArgs e)
        {
            this.bt10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt11_MouseLeave(object sender, EventArgs e)
        {
            this.bt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt13_MouseLeave(object sender, EventArgs e)
        {
            this.bt13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }


        private void bt16_MouseLeave(object sender, EventArgs e)
        {
            this.bt16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt17_MouseLeave(object sender, EventArgs e)
        {
            this.bt17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt7_MouseLeave(object sender, EventArgs e)
        {
            this.bt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            Bordereau_Mise bm = new Bordereau_Mise();
            bm.MdiParent = this;
            bm.Show();
            this.panel2.Visible = false;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            Decompte_Mise m = new Decompte_Mise();
            m.MdiParent = this;
            m.Show();
            this.panel2.Visible = false;
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            BordureauPrixAppro_Mise m = new BordureauPrixAppro_Mise();
            m.MdiParent = this;
            m.Show();
            this.panel2.Visible = false;
        }

        private void bt16_Click(object sender, EventArgs e)
        {
            BordureauPrixPres_Mise m = new BordureauPrixPres_Mise();
            m.MdiParent = this;
            m.Show();
            this.panel2.Visible = false;
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            PrixAppro_Mise m = new PrixAppro_Mise();
            m.MdiParent = this;
            m.Show();
            this.panel2.Visible = false;
        }

        private void bt17_Click(object sender, EventArgs e)
        {
            PrixPrestation_Mise m = new PrixPrestation_Mise();
            m.MdiParent = this;
            m.Show();
            this.panel2.Visible = false;
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            Attachement_Mise m = new Attachement_Mise();
            m.MdiParent = this;
            m.Show();
            this.panel2.Visible = false;
        }

        private void bk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        

     

       
    }
}
