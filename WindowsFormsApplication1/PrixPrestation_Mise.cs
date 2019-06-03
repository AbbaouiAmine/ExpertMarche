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
    public partial class PrixPrestation_Mise : Form
    {
        public PrixPrestation_Mise()
        {
            InitializeComponent();
        }

        private void bt2_Click(object sender, EventArgs e)
        {

            
        }


        private void bt3_Click(object sender, EventArgs e)
        {
            
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            
        }

        private void PrixPrestation_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                string code_prixpres = textBox1.Text;
                int px_n = int.Parse(textBox2.Text);
                string ref_cps_cpc = textBox3.Text;
                string desig = textBox4.Text;
                string unite_mesure = textBox5.Text;
                Prixprestation p = new Prixprestation(code_prixpres, px_n, ref_cps_cpc, desig, unite_mesure);
                p.Ajouter();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voulez vous vraiment supprimer ce enregistrement ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region Suppression
                try
                {
                    string code_prixpres = textBox1.Text;
                    Prixprestation p = new Prixprestation();
                    p.Code_prixpres = code_prixpres;
                    p.Supprimer();
                    MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region Modification
            try
            {
                string code_prixpres = textBox1.Text;
                int px_n = int.Parse(textBox2.Text);
                string ref_cps_cpc = textBox3.Text;
                string desig = textBox4.Text;
                string unite_mesure = textBox5.Text;
                Prixprestation p = new Prixprestation(code_prixpres, px_n, ref_cps_cpc, desig, unite_mesure);
                p.Modifier();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox1.Text, "PRIXPRESTATION");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("PRIXPRESTATION");
                textBox2.Text = dt.Rows[pos][2].ToString();
                textBox3.Text = dt.Rows[pos][3].ToString();
                textBox4.Text = dt.Rows[pos][4].ToString();
                textBox5.Text = dt.Rows[pos][5].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
