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
    public partial class Decompte_Mise : Form
    {
        public Decompte_Mise()
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

        private void Decompte_Mise_Click(object sender, EventArgs e)
        {
            
        }

        private void Decompte_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
            Services.comboBoxRemplissage(ref comboBox1, "ATTACHEMENTS", "CODE_ATTACHE", "N_ATTACHE");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region Ajout
            try
            {
                string code = comboBox1.SelectedValue.ToString();
                DateTime date = dateTimePicker1.Value;
                Decompte a = new Decompte(code, date);
                a.Ajouter();
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
                    string code = comboBox1.SelectedValue.ToString();
                    Decompte a = new Decompte();
                    a.Code_decompte = code;
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

        private void button5_Click(object sender, EventArgs e)
        {
            #region Modification
            try
            {
                string code = comboBox1.SelectedValue.ToString();
                DateTime date = dateTimePicker1.Value;
                Decompte a = new Decompte(code, date);
                a.Modifier();
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
            int pos = Services.Recherche(comboBox1.SelectedValue.ToString(), "BORDERAUX_DETAIL");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("BORDERAUX_DETAIL");
                dateTimePicker1.Value = DateTime.Parse(dt.Rows[pos][2].ToString());
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
