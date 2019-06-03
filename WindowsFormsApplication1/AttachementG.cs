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
    public partial class AttachementG : Form
    {
        public AttachementG()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            string r1 = "select PRIXPRESTATION.[PX_N],PRIXPRESTATION.[DESIG],PRIXPRESTATION.UNITE_MESURE,BORDUREAUPRIXPRES.QUANTITE ";
            string r2 = "from  PRIXPRESTATION, BORDUREAUPRIXPRES  ";
            string r3 = "where PRIXPRESTATION.N_PRIXPRES = BORDUREAUPRIXPRES.N_PRIXPRES and BORDUREAUPRIXPRES.N_ATTACHE = "+comboBoxP1.SelectedValue.ToString();
            string req = r1 + r2 + r3;
            Services.listViewremplissage(ref listView1, Services.executeQuery(req));
        }

        private void AttachementG_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            timeLabel.Text = d.Day.ToString() + " / " + d.Month.ToString() + " / " + d.Year.ToString();
            Services.comboBoxRemplissage(ref comboBoxP1, "ATTACHEMENTS", "CODE_ATTACHE", "N_ATTACHE");
            Services.comboBoxRemplissage(ref comboBoxP3, "PRIXPRESTATION", "DESIG", "N_PRIXPRES");
            Services.comboBoxRemplissage(ref comboBoxA1, "ATTACHEMENTS", "CODE_ATTACHE", "N_ATTACHE");
            Services.comboBoxRemplissage(ref comboBoxA3, "PRIXAPPRO", "DESIG", "N_PRIXAPPRO");
            listView1.GridLines = true;
            listView2.GridLines = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                string code_bordureauprixappro = textBoxP2.Text;
                double quantite = double.Parse(textBoxP4.Text);
                int n_attache = int.Parse(comboBoxP1.SelectedValue.ToString());
                int n_prixappro = int.Parse(comboBoxP3.SelectedValue.ToString());
                Bordereauprixpres p = new Bordereauprixpres(code_bordureauprixappro, n_attache, n_prixappro, quantite);
                p.Ajouter();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //List view 1:
                string r1 = "select PRIXPRESTATION.[PX_N],PRIXPRESTATION.[DESIG],PRIXPRESTATION.UNITE_MESURE,BORDUREAUPRIXPRES.QUANTITE ";
                string r2 = "from  PRIXPRESTATION, BORDUREAUPRIXPRES  ";
                string r3 = "where PRIXPRESTATION.N_PRIXPRES = BORDUREAUPRIXPRES.N_PRIXPRES and BORDUREAUPRIXPRES.N_ATTACHE = " + comboBoxP1.SelectedValue.ToString();
                string req = r1 + r2 + r3;
                Services.listViewremplissage(ref listView1, Services.executeQuery(req));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                string code_bordureauprixappro = textBoxA2.Text;
                double quantite = double.Parse(textBoxA4.Text);
                int n_attache = int.Parse(comboBoxA1.SelectedValue.ToString());
                int n_prixappro = int.Parse(comboBoxA3.SelectedValue.ToString());
                Bordereauprixappro p = new Bordereauprixappro(code_bordureauprixappro, n_attache, n_prixappro, quantite);
                p.Ajouter();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string r1 = "select PRIXAPPRO.[PX_N],PRIXAPPRO.[DESIG],PRIXAPPRO.UNITE_MESURE,BORDUREAUPRIXAPPRO.QUANTITE ";
                string r2 = "from  PRIXAPPRO, BORDUREAUPRIXAPPRO  ";
                string r3 = "where PRIXAPPRO.N_PRIXAPPRO = BORDUREAUPRIXAPPRO.N_PRIXAPPRO and BORDUREAUPRIXAPPRO.N_ATTACHE = " + comboBoxA1.SelectedValue.ToString();
                string req = r1 + r2 + r3;
                Services.listViewremplissage(ref listView2, Services.executeQuery(req));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
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

        private void bt16_MouseLeave(object sender, EventArgs e)
        {
            this.bt16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt11_MouseLeave(object sender, EventArgs e)
        {
            this.bt11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            panelA.Visible = true;
            panelP.Visible = false;
        }

        private void bt16_Click(object sender, EventArgs e)
        {
            panelP.Visible = true;
            panelA.Visible = false;
        }

        private void comboBoxA1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string r1 = "select PRIXAPPRO.[PX_N],PRIXAPPRO.[DESIG],PRIXAPPRO.UNITE_MESURE,BORDUREAUPRIXAPPRO.QUANTITE ";
            string r2 = "from  PRIXAPPRO, BORDUREAUPRIXAPPRO  ";
            string r3 = "where PRIXAPPRO.N_PRIXAPPRO = BORDUREAUPRIXAPPRO.N_PRIXAPPRO and BORDUREAUPRIXAPPRO.N_ATTACHE = "+comboBoxA1.SelectedValue.ToString();
            string req = r1 + r2 + r3;
            Services.listViewremplissage(ref listView2, Services.executeQuery(req));
        }
    }
}
