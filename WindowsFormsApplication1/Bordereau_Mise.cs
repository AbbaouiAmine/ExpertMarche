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
    public partial class Bordereau_Mise : Form
    {
        public Bordereau_Mise()
        {
            InitializeComponent();
        }

        private void Bordereau_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
            Services.comboBoxRemplissage(ref comboBox5, "MARCHESP", "OBJET", "N_MARCHE");
            Services.comboBoxRemplissage(ref comboBox6, "PRIXPRESTATION", "DESIG", "N_PRIXPRES");
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

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                string code_brd = textBox1.Text;
                DateTime date_bord = dateTimePicker2.Value;
                double quantite = double.Parse(textBox3.Text);
                double prix_un = double.Parse(textBox4.Text);
                int n_marche = int.Parse(comboBox5.SelectedValue.ToString());
                int n_prix = int.Parse(comboBox6.SelectedValue.ToString());
                Bordereau b = new Bordereau(code_brd, date_bord, quantite, prix_un, n_marche, n_prix);
                b.Ajouter();
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
            #region Modifier
            try
            {
                string code_brd = textBox1.Text;
                DateTime date_bord = dateTimePicker2.Value;
                double quantite = double.Parse(textBox3.Text);
                double prix_un = double.Parse(textBox4.Text);
                int n_marche = int.Parse(comboBox5.SelectedValue.ToString());
                int n_prix = int.Parse(comboBox6.SelectedValue.ToString());
                Bordereau b = new Bordereau(code_brd, date_bord, quantite, prix_un, n_marche, n_prix);
                b.Modifier();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce enregistrement ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region Suppression
                try
                {
                    string code_brd = textBox1.Text;
                    Bordereau b = new Bordereau();
                    b.Code_brd = code_brd;
                    b.Supprimer();
                    MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox1.Text, "BORDERAUX_DETAIL");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("BORDERAUX_DETAIL");
                
                dateTimePicker2.Value = DateTime.Parse(dt.Rows[pos][2].ToString());
                textBox3.Text = dt.Rows[pos][3].ToString();
                textBox4.Text = dt.Rows[pos][4].ToString();
                comboBox5.Text = dt.Rows[pos][5].ToString();
                comboBox6.Text = dt.Rows[pos][6].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
