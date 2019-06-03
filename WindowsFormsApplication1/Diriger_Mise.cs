using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Diriger_Mise : Form
    {
        public Diriger_Mise()
        {
            InitializeComponent();
        }

        #region Remplissage des comboBox
        private void Diriger_Mise_Load(object sender, EventArgs e)
        {

            try
            {
                Services.comboBoxRemplissage(ref comboBox5, "DIRECTEUR", "CODE_DIRECTEUR", "N_DIRECTEUR");
                Services.comboBoxRemplissage(ref comboBox6, "DIRECTIONS", "CODE_DIREC", "N_DIREC");
                this.Location = new System.Drawing.Point(269, 152);
                this.ClientSize = new System.Drawing.Size(641, 302);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Operation de MAJ
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region Button de déplacement
        private void button5_Click(object sender, EventArgs e)
        {
            #region >>
            try
            {
                Services.table = Services.selectTable("Diriger");
                Services.c++;
                if (Services.c >= Services.table.Rows.Count)
                    Services.c = Services.table.Rows.Count - 1;

                textBox2.Text = Services.table.Rows[Services.c][1].ToString(); ;
                dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
                dateTimePicker4.Value = DateTime.Parse(Services.table.Rows[Services.c][3].ToString());
                comboBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region <<
            Services.table = Services.selectTable("Diriger");
            Services.c--;
            if (Services.c < 0)
                Services.c = 0;
            textBox2.Text = Services.table.Rows[Services.c][1].ToString(); ;
            dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
            dateTimePicker4.Value = DateTime.Parse(Services.table.Rows[Services.c][3].ToString());
            comboBox5.Text = Services.table.Rows[Services.c][4].ToString();
            comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region |<
            try
            {
                Services.table = Services.selectTable("Diriger");
                Services.c = 0;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString(); ;
                dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
                dateTimePicker4.Value = DateTime.Parse(Services.table.Rows[Services.c][3].ToString());
                comboBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
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
                Services.table = Services.selectTable("Diriger");
                Services.c = Services.table.Rows.Count - 1;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString(); ;
                dateTimePicker3.Value = DateTime.Parse(Services.table.Rows[Services.c][2].ToString());
                dateTimePicker4.Value = DateTime.Parse(Services.table.Rows[Services.c][3].ToString());
                comboBox5.Text = Services.table.Rows[Services.c][4].ToString();
                comboBox6.Text = Services.table.Rows[Services.c][5].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }
        #endregion

        private void button5_Click_1(object sender, EventArgs e)
        {
            #region Modification
            try
            {
                //int n_dirige = textBox1.Text;
                string code_dirige = textBox2.Text;
                DateTime date_deb = dateTimePicker3.Value;
                DateTime date_fin = dateTimePicker4.Value;
                int direct = int.Parse(comboBox5.SelectedItem.ToString());
                int direction = int.Parse(comboBox6.SelectedItem.ToString());
                Diriger d = new Diriger(code_dirige, date_deb, date_fin, direct, direction);
                d.Modifier();
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
                    //int n_dirige = textBox1.Text;
                    string code_dirige = textBox2.Text;
                    Diriger d = new Diriger();
                    d.Code_dirige = code_dirige;
                    d.Supprimer();
                    MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion 
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                //int n_dirige = textBox1.Text;
                string code_dirige = textBox2.Text;
                DateTime date_deb = dateTimePicker3.Value;
                DateTime date_fin = dateTimePicker4.Value;
                int direct = int.Parse(comboBox5.SelectedItem.ToString());
                int direction = int.Parse(comboBox6.SelectedItem.ToString());
                Diriger d = new Diriger(code_dirige, date_deb, date_fin, direct, direction);
                d.Ajouter();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox2.Text, "DIRIGER");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("DIRIGER");
                dateTimePicker3.Text = dt.Rows[pos][2].ToString();
                dateTimePicker4.Text = dt.Rows[pos][3].ToString();
                comboBox5.Text = dt.Rows[pos][4].ToString();
                comboBox6.Text = dt.Rows[pos][5].ToString();  
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
