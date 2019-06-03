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
    public partial class Attachement_Mise : Form
    {
        public Attachement_Mise()
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

        private void Attachement_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                string code_attachement = textBox1.Text;
                DateTime date_attachement = dateTimePicker2.Value;
                Attachement a = new Attachement(code_attachement, date_attachement);
                a.Ajouter();
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
            #region Modification
            try
            {
                string code_attachement = textBox1.Text;
                DateTime date_attachement = dateTimePicker2.Value;
                Attachement a = new Attachement(code_attachement, date_attachement);
                a.Modifier();
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
                    string code_attachement = textBox1.Text;
                    Attachement a = new Attachement();
                    a.Code_attachement = code_attachement;
                    a.Supprimer();
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
            int pos = Services.Recherche(textBox1.Text, "ATTACHEMENTS");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("ATTACHEMENTS");
                dateTimePicker2.Value = DateTime.Parse(dt.Rows[pos][2].ToString());
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
