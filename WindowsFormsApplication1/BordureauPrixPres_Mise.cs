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
    public partial class BordureauPrixPres_Mise : Form
    {
        public BordureauPrixPres_Mise()
        {
            InitializeComponent();
        }

        private void BordureauPrixPres_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
            Services.comboBoxRemplissage(ref comboBox3, "ATTACHEMENTS", "CODE_ATTACHE", "N_ATTACHE");
            Services.comboBoxRemplissage(ref comboBox4, "PRIXPRESTATION", "CODE_PRIXPRES", "N_PRIXPRES");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                string code_bordureauprixappro = textBox11.Text;
                double quantite = double.Parse(textBox2.Text);
                int n_attache = int.Parse(comboBox3.SelectedValue.ToString());
                int n_prixappro = int.Parse(comboBox4.SelectedValue.ToString());
                Bordereauprixpres p = new Bordereauprixpres(code_bordureauprixappro, n_attache, n_prixappro, quantite);
                p.Ajouter();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region Modifier
            try
            {
                string code_bordureauprixappro = textBox11.Text;
                double quantite = double.Parse(textBox2.Text);
                int n_attache = int.Parse(comboBox3.SelectedValue.ToString());
                int n_prixappro = int.Parse(comboBox4.SelectedValue.ToString());
                Bordereauprixpres p = new Bordereauprixpres(code_bordureauprixappro, n_attache, n_prixappro, quantite);
                p.Modifier();
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
                #region Ajout
                try
                {
                    string code_bordureauprixappro = textBox11.Text;
                    Bordereauprixpres p = new Bordereauprixpres();
                    p.Code_bordureauprixpres = code_bordureauprixappro;
                    p.Ajouter();
                    MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox11.Text, "BORDUREAUPRIXPRES");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("BORDUREAUPRIXPRES");
                textBox2.Text = dt.Rows[pos][2].ToString();
                comboBox3.Text = dt.Rows[pos][3].ToString();
                comboBox4.Text = dt.Rows[pos][4].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
