using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions;
using CrystalDecisions.Shared;

namespace WindowsFormsApplication1
{
    public partial class AttachementEtat : Form
    {
        public AttachementEtat()
        {
            InitializeComponent();
        }

        private void AttachementEtat_Load(object sender, EventArgs e)
        {
            string req = "select	N_ATTACHE,CODE_ATTACHE from   ATTACHEMENTS where N_MARCHE =  (select top 1 N_MARCHE  from MARCHESP order by DATE_DEBUT  desc)";
            Services.comboBoxRemplissageData(ref comboBox1, req, "CODE_ATTACHE", "N_ATTACHE");
            comboBox1.Text = "Selectionnez un attachement"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EtatAttachement et = new EtatAttachement();
            et.SetParameterValue("attt",comboBox1.SelectedValue.ToString());
            et.SetParameterValue("num", comboBox1.SelectedText.ToString());
            et.SetParameterValue("numA", comboBox1.SelectedValue.ToString());

            crystalReportViewer1.ReportSource = et;
        }
    }
}
