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
    public partial class MarchésP_Mise : Form
    {
        public MarchésP_Mise()
        {
            InitializeComponent();
        }

        #region Remplissage des comboBox
        private void MarchésP_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
            Services.comboBoxRemplissage(ref comboBox6, "PRESTATAIRE", "CODE_PREST", "N_PREST");

        }
        #endregion

        #region Operation de MAJ
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Button de déplacement
        private void button5_Click(object sender, EventArgs e)
        {
            #region >>
            try
            {
                Services.table = Services.selectTable("MARCHESP");
                Services.c++;
                if (Services.c >= Services.table.Rows.Count)
                    Services.c = Services.table.Rows.Count - 1;

                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.SelectedValue = Services.table.Rows[Services.c][5].ToString();
                dateTimePicker7.Value = DateTime.Parse(Services.table.Rows[Services.c][6].ToString());
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                dateTimePicker9.Value = DateTime.Parse(Services.table.Rows[Services.c][8].ToString());
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region <<
            try
            {
                Services.table = Services.selectTable("MARCHESP");
                Services.c--;
                if (Services.c < 0)
                    Services.c = 0;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.SelectedValue = Services.table.Rows[Services.c][5].ToString();
                dateTimePicker7.Value = DateTime.Parse(Services.table.Rows[Services.c][6].ToString());
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                dateTimePicker9.Value = DateTime.Parse(Services.table.Rows[Services.c][8].ToString());
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region |<
            try
            {
                Services.table = Services.selectTable("MARCHESP");
                Services.c = 0;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.SelectedValue = Services.table.Rows[Services.c][5].ToString();
                dateTimePicker7.Value = DateTime.Parse(Services.table.Rows[Services.c][6].ToString());
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                dateTimePicker9.Value = DateTime.Parse(Services.table.Rows[Services.c][8].ToString());
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region >|
            try
            {
                Services.table = Services.selectTable("MARCHESP");
                Services.c = Services.table.Rows.Count - 1;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.SelectedValue = Services.table.Rows[Services.c][5].ToString();
                dateTimePicker7.Value = DateTime.Parse(Services.table.Rows[Services.c][6].ToString());
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                dateTimePicker9.Value = DateTime.Parse(Services.table.Rows[Services.c][8].ToString());
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }
        #endregion

        private void button7_Click_1(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                //int n_marche = textBox1.Text;
                string code_marche = textBox2.Text;
                string annee = textBox3.Text;
                string objet = textBox4.Text;
                string type_prestation = textBox5.Text;
                int prest = int.Parse(comboBox6.SelectedValue.ToString());
                DateTime date_debut = dateTimePicker7.Value;
                double delai = double.Parse(textBox8.Text);
                DateTime date_fin_realisation = dateTimePicker9.Value;
                double montant_engage = double.Parse(textBox10.Text);
                MarchésP p = new MarchésP(code_marche, annee, objet, type_prestation, prest, date_debut, delai, date_fin_realisation, montant_engage);
                p.Ajouter();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            #region Modification
            try
            {

                //int n_marche = textBox1.Text;
                string code_marche = textBox2.Text;
                string annee = textBox3.Text;
                string objet = textBox4.Text;
                string type_prestation = textBox5.Text;
                int prest = int.Parse(comboBox6.SelectedValue.ToString());
                DateTime date_debut = dateTimePicker7.Value;
                double delai = double.Parse(textBox8.Text);
                DateTime date_fin_realisation = dateTimePicker9.Value;
                double montant_engage = double.Parse(textBox10.Text);
                MarchésP p = new MarchésP(code_marche, annee, objet, type_prestation, prest, date_debut, delai, date_fin_realisation, montant_engage);
                p.Modifier();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce enregistrement ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region Suppression
                try
                {
                    //int n_marche = textBox1.Text;
                    string code_marche = textBox2.Text;
                    MarchésP p = new MarchésP();
                    p.Code_marche = code_marche;
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox2.Text, "MARCHESP");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("MARCHESP");
                textBox3.Text = dt.Rows[pos][2].ToString();
                textBox4.Text = dt.Rows[pos][3].ToString();
                textBox5.Text = dt.Rows[pos][4].ToString();
                comboBox6.Text = dt.Rows[pos][5].ToString();
                dateTimePicker7.Text = dt.Rows[pos][6].ToString();
                textBox8.Text = dt.Rows[pos][7].ToString();
                dateTimePicker9.Text = dt.Rows[pos][8].ToString();
                textBox10.Text = dt.Rows[pos][9].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
