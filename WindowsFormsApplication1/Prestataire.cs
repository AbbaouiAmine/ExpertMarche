using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Prestataire
    {
        //Attribues
        //private int n_prest;
        private string code_prest;
        private string rai_soc;
        private string intitule;
        private DateTime date_creation;
        private string activite;
        private string contact;
        private string adr_siege;
        private string tel_b;
        private string fax;
        private string gsm_contact;
        private string e_mail;
        private string site_web;
        //Les propriétés
     
        public string Code_prest
        {
            get { return code_prest; }
            set { code_prest = value; }
        }
        public string Rai_soc
        {
            get { return rai_soc; }
            set { rai_soc = value; }
        }
        public string Intitule
        {
            get { return intitule; }
            set { intitule = value; }
        }
        public DateTime Date_creation
        {
            get { return date_creation; }
            set { date_creation = value; }
        }
        public string Activite
        {
            get { return activite; }
            set { activite = value; }
        }
        public string Adr_siege
        {
            get { return adr_siege; }
            set { adr_siege = value; }
        }
        
        public string Tel_b
        {
            get { return tel_b; }
            set { tel_b = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public string Gsm_contact
        {
            get { return gsm_contact; }
            set { gsm_contact = value; }
        }
        public string E_mail
        {
            get { return e_mail; }
            set { e_mail = value; }
        }
        public string Site_web
        {
            get { return site_web; }
            set { site_web = value; }
        }
        //Les constructeurs
        public Prestataire()//constructeur par défaut
        { }
        public Prestataire(string code_prest, string rai_soc, string intitule, DateTime date_creation, string activite, string contact, string adr_siege, string fax, string gsm_contact, string e_mail, string site_web, string tel_b)
        {
            this.Code_prest=code_prest;
            this.Rai_soc =rai_soc;
            this.Intitule=rai_soc;
            this.Date_creation=date_creation;
            this.Activite=activite;
            this.Contact=contact;
            this.Adr_siege=adr_siege;
            this.Fax=fax;
            this.Gsm_contact=gsm_contact;
            this.E_mail=e_mail;
            this.Site_web=site_web;
            this.Tel_b = tel_b;
        }
        //Méthodes de mise à jour
        public void Ajouter()
        {

            string req = "INSERT INTO PRESTATAIRE( CODE_PREST, RAI_SOC, INTITULE, DATE_CREATION, ACTIVITE, ADR_SIEGE, TEL_B, FAX, CONTACT, GSM_CONTACT, E_MAIL, SITE_WEB ) VALUES( @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12) ";
            Services.con.Open();
            SqlParameter p1 = new SqlParameter("@p1",this.Code_prest);
            SqlParameter p2 = new SqlParameter("@p2", this.Rai_soc);
            SqlParameter p3 = new SqlParameter("@p3", this.Intitule);
            SqlParameter p4 = new SqlParameter("@p4", this.Date_creation);
            SqlParameter p5 = new SqlParameter("@p5", this.Activite);
            SqlParameter p6 = new SqlParameter("@p6", this.Adr_siege);
            SqlParameter p7 = new SqlParameter("@p7", this.Tel_b);
            SqlParameter p8 = new SqlParameter("@p8", this.Fax);
            SqlParameter p9 = new SqlParameter("@p9", this.Contact);
            SqlParameter p10 = new SqlParameter("@p10", this.Gsm_contact);
            SqlParameter p11 = new SqlParameter("@p11", this.E_mail);
            SqlParameter p12 = new SqlParameter("@p12", this.Site_web);
            SqlCommand cmd = new SqlCommand(req,Services.con);
            
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            cmd.Parameters.Add(p11);
            cmd.Parameters.Add(p12);
            
            
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  PRESTATAIRE set (RAI_SOC=@p2, INTITULE=@p3, DATE_CREATION=@p4, ACTIVITE=@p5, ADR_SIEGE=@p6, TEL_B=@p7, FAX=@p8, CONTACT=@p9, GSM_CONTACT=@p10, E_MAIL=@p11, SITE_WEB=@p12 ) where  CODE_PREST=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prest);
            SqlParameter p2 = new SqlParameter("@p2", this.Rai_soc);
            SqlParameter p3 = new SqlParameter("@p3", this.Intitule);
            SqlParameter p4 = new SqlParameter("@p4", this.Date_creation);
            SqlParameter p5 = new SqlParameter("@p5", this.Activite);
            SqlParameter p6 = new SqlParameter("@p6", this.Adr_siege);
            SqlParameter p7 = new SqlParameter("@p7", this.Tel_b);
            SqlParameter p8 = new SqlParameter("@p8", this.Fax);
            SqlParameter p9 = new SqlParameter("@p9", this.Contact);
            SqlParameter p10 = new SqlParameter("@p10", this.Gsm_contact);
            SqlParameter p11 = new SqlParameter("@p11", this.E_mail);
            SqlParameter p12 = new SqlParameter("@p12", this.Site_web);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            cmd.Parameters.Add(p11);
            cmd.Parameters.Add(p12);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {

            string req = "Delete from  PRESTATAIRE where CODE_PREST=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prest);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
       

    }
}
