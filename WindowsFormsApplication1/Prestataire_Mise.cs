using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Prestataire_Mise : Form
    {
        public Prestataire_Mise()
        {
            InitializeComponent();
        }

        #region Operation de MAJ
        private void bt2_Click(object sender, EventArgs e)
        {
            
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            
        }
        private void bt4_Click(object sender, EventArgs e)
        {
            
        }
        


        #endregion

        #region Button de déplacement
        
        private void panel6_Click(object sender, EventArgs e)
        {
            #region |<
            try
            {
                Services.table = Services.selectTable("Prestataire");
                Services.c = 0;

                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                dateTimePicker5.Value = DateTime.Parse(Services.table.Rows[Services.c][4].ToString());
                textBox6.Text = Services.table.Rows[Services.c][5].ToString();
                textBox7.Text = Services.table.Rows[Services.c][6].ToString();
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                textBox9.Text = Services.table.Rows[Services.c][8].ToString();
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
                textBox11.Text = Services.table.Rows[Services.c][10].ToString();
                textBox12.Text = Services.table.Rows[Services.c][11].ToString();
                textBox13.Text = Services.table.Rows[Services.c][12].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            #region >|
            try
            {
                Services.table = Services.selectTable("Prestataire");
                Services.c = Services.table.Rows.Count - 1;

                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                dateTimePicker5.Value = DateTime.Parse(Services.table.Rows[Services.c][4].ToString());
                textBox6.Text = Services.table.Rows[Services.c][5].ToString();
                textBox7.Text = Services.table.Rows[Services.c][6].ToString();
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                textBox9.Text = Services.table.Rows[Services.c][8].ToString();
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
                textBox11.Text = Services.table.Rows[Services.c][10].ToString();
                textBox12.Text = Services.table.Rows[Services.c][11].ToString();
                textBox13.Text = Services.table.Rows[Services.c][12].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

      

      
        private void panel5_Click(object sender, EventArgs e)
        {
            #region <<
            try
            {
                Services.table = Services.selectTable("Prestataire");
                Services.c--;
                if (Services.c < 0)
                    Services.c = 0;

                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                dateTimePicker5.Value = DateTime.Parse(Services.table.Rows[Services.c][4].ToString());
                textBox6.Text = Services.table.Rows[Services.c][5].ToString();
                textBox7.Text = Services.table.Rows[Services.c][6].ToString();
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                textBox9.Text = Services.table.Rows[Services.c][8].ToString();
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
                textBox11.Text = Services.table.Rows[Services.c][10].ToString();
                textBox12.Text = Services.table.Rows[Services.c][11].ToString();
                textBox13.Text = Services.table.Rows[Services.c][12].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            #region >>
            try
            {
                Services.table = Services.selectTable("Prestataire");
                Services.c++;
                if (Services.c >= Services.table.Rows.Count)
                    Services.c = Services.table.Rows.Count - 1;

                textBox2.Text = Services.table.Rows[Services.c][1].ToString();
                textBox3.Text = Services.table.Rows[Services.c][2].ToString();
                textBox4.Text = Services.table.Rows[Services.c][3].ToString();
                dateTimePicker5.Value = DateTime.Parse(Services.table.Rows[Services.c][4].ToString());
                textBox6.Text = Services.table.Rows[Services.c][5].ToString();
                textBox7.Text = Services.table.Rows[Services.c][6].ToString();
                textBox8.Text = Services.table.Rows[Services.c][7].ToString();
                textBox9.Text = Services.table.Rows[Services.c][8].ToString();
                textBox10.Text = Services.table.Rows[Services.c][9].ToString();
                textBox11.Text = Services.table.Rows[Services.c][10].ToString();
                textBox12.Text = Services.table.Rows[Services.c][11].ToString();
                textBox13.Text = Services.table.Rows[Services.c][12].ToString();
            }
            catch (Exception ex)
            {

            }
            #endregion
        }
        
        #endregion

        private void Prestataire_Mise_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(269, 152);
            this.ClientSize = new System.Drawing.Size(641, 302);
            //Services.coloriser(0xffffff, this.head);
            
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Menu_Mise_a_jour m = new Menu_Mise_a_jour();
            m.Show();
            this.Dispose();
        }

        private void bt1_MouseEnter(object sender, EventArgs e)
        {
            
        }

       

        

        private void button1_Click(object sender, EventArgs e)
        {
            #region Ajout : Prestaire
            try
            {
                string code_prest = textBox2.Text;
                string rai_soc = textBox3.Text;
                string intitule = textBox4.Text;
                DateTime date_creation = dateTimePicker5.Value;
                string activite = textBox6.Text;
                string adr_siege = textBox7.Text;
                string tel_b = textBox8.Text;
                string fax = textBox9.Text;
                string contact = textBox10.Text;
                string gsm_contact = textBox11.Text;
                string e_mail = textBox12.Text;
                string site_web = textBox13.Text;
                Prestataire p = new Prestataire(code_prest, rai_soc, intitule, date_creation, activite, contact, adr_siege, fax, gsm_contact, e_mail, site_web, tel_b);
                p.Ajouter();
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
                #region  Suppression : Prestataire
                try
                {
                    Prestataire p = new Prestataire();
                    p.Code_prest = textBox2.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            #region Modification : Prestataire
            try
            {
                string code_prest = textBox2.Text;
                string rai_soc = textBox3.Text;
                string intitule = textBox4.Text;
                DateTime date_creation = dateTimePicker5.Value;
                string activite = textBox6.Text;
                string adr_siege = textBox7.Text;
                string tel_b = textBox8.Text;
                string fax = textBox9.Text;
                string contact = textBox10.Text;
                string gsm_contact = textBox11.Text;
                string e_mail = textBox12.Text;
                string site_web = textBox13.Text;
                Prestataire p = new Prestataire(code_prest, rai_soc, intitule, date_creation, activite, contact, adr_siege, fax, gsm_contact, e_mail, site_web, tel_b);
                p.Modifier();
                MessageBox.Show("Opération effectué", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pos = Services.Recherche(textBox2.Text, "PRESTATAIRE");
            if (pos != -1)
            {
                DataTable dt = new DataTable();
                dt = Services.selectTable("PRESTATAIRE");
                textBox3.Text = dt.Rows[pos][2].ToString();
                textBox4.Text = dt.Rows[pos][3].ToString();
                dateTimePicker5.Text = dt.Rows[pos][4].ToString();
                textBox6.Text = dt.Rows[pos][5].ToString();
                textBox7.Text = dt.Rows[pos][6].ToString();
                textBox8.Text = dt.Rows[pos][7].ToString();
                textBox9.Text = dt.Rows[pos][8].ToString();
                textBox10.Text = dt.Rows[pos][9].ToString();
                textBox11.Text = dt.Rows[pos][10].ToString();
                textBox12.Text = dt.Rows[pos][11].ToString();
                textBox13.Text = dt.Rows[pos][12].ToString();
            }
            else
            {
                MessageBox.Show("Aucun élément rouvé !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        

       
       
       

      

       

       

        
    }
}
