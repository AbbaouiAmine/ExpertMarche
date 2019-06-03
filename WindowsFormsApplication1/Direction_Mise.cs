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
    public partial class Direction_Mise : Form
    {
        public Direction_Mise()
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
            try
            {
                Services.table = Services.selectTable("DIRECTIONS");
                Services.c++;
                if (Services.c >= Services.table.Rows.Count)
                Services.c = Services.table.Rows.Count - 1;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region <<
            try
            {
                Services.table = Services.selectTable("DIRECTIONS");
                Services.c--;
                if (Services.c < 0)
                Services.c = 0;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();

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
                Services.table = Services.selectTable("DIRECTIONS");
                Services.c = 0;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region >|
            try
            {
                Services.table = Services.selectTable("DIRECTIONS");
                Services.c = Services.table.Rows.Count - 1;
                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                textBox5.Text = Services.table.Rows[Services.c][4].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }
        #endregion

        private void Direction_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                //string n_direc = textBox1.Text;
                string code_direc = textBox2.Text;
                string type_direc = textBox3.Text;
                string ville = textBox4.Text;
                string region = textBox5.Text;
                Direction d = new Direction(code_direc, type_direc, ville, region);
                d.Ajouter();
                MessageBox.Show("Modification effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //string n_direc = textBox1.Text;
                    string code_direc = textBox2.Text;
                    Direction d = new Direction();
                    d.Code_direc = code_direc;
                    d.Supprimer();
                    MessageBox.Show("Modification effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion 
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            #region Modification
            try
            {
                //string n_direc = textBox1.Text;
                string code_direc = textBox2.Text;
                string type_direc = textBox3.Text;
                string ville = textBox4.Text;
                string region = textBox5.Text;
                Direction d = new Direction(code_direc, type_direc, ville, region);
                d.Modifier();
                MessageBox.Show("Modification effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox2.Text, "DIRECTIONS");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("DIRECTIONS");
                textBox3.Text = dt.Rows[pos][2].ToString();
                textBox4.Text = dt.Rows[pos][3].ToString();
                textBox5.Text = dt.Rows[pos][4].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
