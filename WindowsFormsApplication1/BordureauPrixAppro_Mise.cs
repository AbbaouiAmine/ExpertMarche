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
    public partial class BordureauPrixAppro_Mise : Form
    {
        public BordureauPrixAppro_Mise()
        {
            InitializeComponent();
        }

        private void BordureauPrixAppro_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
            Services.comboBoxRemplissage(ref comboBox3,"ATTACHEMENTS","CODE_ATTACHE","N_ATTACHE");
            Services.comboBoxRemplissage(ref comboBox4, "PRIXAPPRO", "CODE_PRIXAPPRO", "N_PRIXAPPRO");
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
             Bordereauprixappro p = new Bordereauprixappro(code_bordureauprixappro, n_attache, n_prixappro, quantite);
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
                    string code_bordureauprixappro = textBox11.Text;
                    Bordereauprixappro p = new Bordereauprixappro();
                    p.Code_bordureauprixappro = code_bordureauprixappro;
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
            #region Ajout
            try
            {
                string code_bordureauprixappro = textBox11.Text;
                double quantite = double.Parse(textBox2.Text);
                int n_attache = int.Parse(comboBox3.SelectedValue.ToString());
                int n_prixappro = int.Parse(comboBox4.SelectedValue.ToString());
                Bordereauprixappro p = new Bordereauprixappro(code_bordureauprixappro, n_attache, n_prixappro, quantite);
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

            int pos = Services.Recherche(textBox11.Text, "BORDUREAUPRIXAPPRO");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("BORDUREAUPRIXAPPRO");
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
