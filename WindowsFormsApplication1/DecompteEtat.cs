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
    public partial class DecompteEtat : Form
    {
        public DecompteEtat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DecompteEtat_Load(object sender, EventArgs e)
        {
            string req = "select	N_ATTACHE,CODE_ATTACHE from   ATTACHEMENTS where N_MARCHE =  (select top 1 N_MARCHE  from MARCHESP order by DATE_DEBUT  desc)";
            Services.comboBoxRemplissageData(ref comboBox1, req, "CODE_ATTACHE", "N_ATTACHE");
            comboBox1.Text = "Selectionnez un attachement";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EtatDecompte et = new EtatDecompte();
            et.SetParameterValue("attt", comboBox1.SelectedValue.ToString());
            et.SetParameterValue("revesionG", textBox1.Text);
            et.SetParameterValue("jourRetardG", textBox2.Text);
            et.SetParameterValue("Budget", textBox3.Text);
            et.SetParameterValue("Chapitre", textBox4.Text);
            et.SetParameterValue("Article", textBox5.Text);
            et.SetParameterValue("Paragraphe", textBox6.Text);
            et.SetParameterValue("Ligne", textBox7.Text);
            //et.SetParameterValue("num", comboBox1.SelectedText.ToString());
            //et.SetParameterValue("numA", comboBox1.SelectedValue.ToString());
            crystalReportViewer1.ReportSource = et;
        }
    }
}
