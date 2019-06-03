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
    public partial class Directeur_Mise : Form
    {
        public Directeur_Mise()
        {
            InitializeComponent();
        }

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
            Services.table = Services.selectTable("Directeur");
            Services.c++;
            if (Services.c >= Services.table.Rows.Count)
                Services.c = Services.table.Rows.Count - 1;
            textBox2.Text = Services.table.Rows[Services.c][1].ToString();
            textBox3.Text = Services.table.Rows[Services.c][2].ToString();
            textBox4.Text = Services.table.Rows[Services.c][3].ToString();
            textBox5.Text = Services.table.Rows[Services.c][4].ToString();
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region <<
            Services.table = Services.selectTable("Directeur");
            Services.c--;
            if (Services.c < 0)
                Services.c = 0;
            textBox2.Text = Services.table.Rows[Services.c][1].ToString();
            textBox3.Text = Services.table.Rows[Services.c][2].ToString();
            textBox4.Text = Services.table.Rows[Services.c][3].ToString();
            textBox5.Text = Services.table.Rows[Services.c][4].ToString();
            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region|<
            Services.table = Services.selectTable("Directeur");
            Services.c = 0;
            textBox2.Text = Services.table.Rows[Services.c][1].ToString();
            textBox3.Text = Services.table.Rows[Services.c][2].ToString();
            textBox4.Text = Services.table.Rows[Services.c][3].ToString();
            textBox5.Text = Services.table.Rows[Services.c][4].ToString();
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region >|
            Services.table = Services.selectTable("Directeur");
            Services.c = Services.table.Rows.Count - 1;
            textBox2.Text = Services.table.Rows[Services.c][1].ToString();
            textBox3.Text = Services.table.Rows[Services.c][2].ToString();
            textBox4.Text = Services.table.Rows[Services.c][3].ToString();
            textBox5.Text = Services.table.Rows[Services.c][4].ToString();
            #endregion
        }
        #endregion   

        private void Directeur_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            #region Ajout : Table Directeur
            try
            {
                //int n_directeur=textBox1.Text;
                string code_directeur = textBox2.Text;
                string nom_direct = textBox3.Text;
                string prenom_direct = textBox4.Text;
                string tel_direct = textBox5.Text;
                string gsm_direct = textBox6.Text;
                Directeur d = new Directeur(code_directeur, nom_direct, prenom_direct, tel_direct, gsm_direct);
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
            #region Modification : table Directeur
            try
            {
                //int n_directeur=textBox1.Text;
                string code_directeur = textBox2.Text;
                string nom_direct = textBox3.Text;
                string prenom_direct = textBox4.Text;
                string tel_direct = textBox5.Text;
                string gsm_direct = textBox6.Text;
                Directeur d = new Directeur(code_directeur, nom_direct, prenom_direct, tel_direct, gsm_direct);
                d.Modifier();
                MessageBox.Show("Modification effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce enregistrement ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                #region Suppression : table Directeur
                try
                {
                    //int n_directeur=textBox1.Text;
                    string code_directeur = textBox2.Text;
                    Directeur d = new Directeur();
                    d.Code_directeur = code_directeur;
                    d.Supprimer();
                    MessageBox.Show("Modification effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                #endregion 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox2.Text, "DIRECTEUR");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("DIRECTEUR");
                textBox3.Text= dt.Rows[pos][2].ToString();
                textBox4.Text = dt.Rows[pos][3].ToString();
                textBox5.Text = dt.Rows[pos][4].ToString();
                textBox6.Text = dt.Rows[pos][5].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
