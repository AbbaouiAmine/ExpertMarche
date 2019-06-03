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
    public partial class Ordre_Service_Mise : Form
    {
        public Ordre_Service_Mise()
        {
            InitializeComponent();
        }

        #region MAJ
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

        #region Remplissage des comboBox
        private void Ordre_Service_Mise_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new System.Drawing.Point(269, 152);
                this.ClientSize = new System.Drawing.Size(641, 302);
                Services.comboBoxRemplissage(ref comboBox6, "ORDONNANCEUR", "CODE_ORDONNANCEUR", "N_ORDONNANCEUR");
                Services.comboBoxRemplissage(ref comboBox7, "MARCHESP", "CODE_MARCHE", "N_MARCHE");
                Services.comboBoxRemplissage(ref comboBox8, "DIRECTEUR", "CODE_DIRECTEUR", "N_DIRECTEUR");
                
            }
            catch (Exception ex)
            {
                
            }
            
        }
        #endregion

        #region Button de déplacement
        private void button3_Click(object sender, EventArgs e)
        {
            #region <<
            try
            {
                Services.table = Services.selectTable("Ordre_Service");
                Services.c--;
                if (Services.c < 0)
                    Services.c = 0;

                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
                comboBox7.Text = Services.table.Rows[Services.c][6].ToString();
                comboBox8.Text = Services.table.Rows[Services.c][7].ToString();
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
                Services.table = Services.selectTable("Ordre_Service");
                Services.c = 0;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
                comboBox7.Text = Services.table.Rows[Services.c][6].ToString();
                comboBox8.Text = Services.table.Rows[Services.c][7].ToString();
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
                Services.table = Services.selectTable("Ordre_Service");
                Services.c = Services.table.Rows.Count - 1;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
                comboBox7.Text = Services.table.Rows[Services.c][6].ToString();
                comboBox8.Text = Services.table.Rows[Services.c][7].ToString();
            }
            catch (Exception ex)
            {

            } 
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region >>
            try
            {
                Services.table = Services.selectTable("Ordre_Service");
                Services.c++;
                if (Services.c >= Services.table.Rows.Count)
                    Services.c = Services.table.Rows.Count - 1;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
                comboBox7.Text = Services.table.Rows[Services.c][6].ToString();
                comboBox8.Text = Services.table.Rows[Services.c][7].ToString();
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
                //int n_ordre = textBox1.Text;
                string code_ordre = textBox2.Text;
                DateTime date_ordre = dateTimePicker3.Value;
                string objet_ordre = textBox4.Text;
                string type_ordre = textBox5.Text;
                int chef_service = int.Parse(comboBox6.SelectedValue.ToString());
                int marche = int.Parse(comboBox7.SelectedValue.ToString());
                int directeur = int.Parse(comboBox8.SelectedValue.ToString());
                Ordre_Service os = new Ordre_Service(code_ordre, date_ordre, objet_ordre, type_ordre, chef_service, marche, directeur);
                os.Ajouter();
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
                string code_ordre = textBox2.Text;
                DateTime date_ordre = dateTimePicker3.Value;
                string objet_ordre = textBox4.Text;
                string type_ordre = textBox5.Text;
                int chef_service = int.Parse(comboBox6.SelectedValue.ToString());
                int marche = int.Parse(comboBox7.SelectedValue.ToString());
                int directeur = int.Parse(comboBox8.SelectedValue.ToString());
                Ordre_Service os = new Ordre_Service(code_ordre, date_ordre, objet_ordre, type_ordre, chef_service, marche, directeur);
                os.Modifier();
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
                    string code_ordre = textBox2.Text;
                    Ordre_Service os = new Ordre_Service();
                    os.Code_ordre = code_ordre;
                    os.Supprimer();
                    MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion 
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox2.Text, "ORDRE_SERVICE");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("ORDRE_SERVICE");
                dateTimePicker3.Text = dt.Rows[pos][2].ToString();
                textBox4.Text = dt.Rows[pos][3].ToString();
                textBox5.Text = dt.Rows[pos][4].ToString();
                comboBox6.Text = dt.Rows[pos][5].ToString();
                comboBox7.Text = dt.Rows[pos][6].ToString();
                comboBox8.Text = dt.Rows[pos][7].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
