using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Directeur
    {
        //Attributs :
        private int n_directeur;
        private string code_directeur;
        private string nom_direct;
        private string prenom_direct;
        private string tel_direct;
        private string gsm_direct;
        //Getters & Setters
       
        public int N_directeur
        {
            get { return n_directeur; }
            set { n_directeur = value; }
        }
        public string Code_directeur
        {
            get { return code_directeur; }
            set { code_directeur = value; }
        }
        public string Nom_direct
        {
            get { return nom_direct; }
            set { nom_direct = value; }
        }
        public string Prenom_direct
        {
            get { return prenom_direct; }
            set { prenom_direct = value; }
        }
        public string Tel_direct
        {
            get { return tel_direct; }
            set { tel_direct = value; }
        }
        public string Gsm_direct
        {
            get { return gsm_direct; }
            set { gsm_direct = value; }
        }
        //Constructeurs
        public Directeur(string code_directeur, string nom_direct, string prenom_direct, string tel_direct, string gsm_direct)
        {
            this.Code_directeur=code_directeur;
            this.Nom_direct=nom_direct;
            this.Prenom_direct=prenom_direct;
            this.Tel_direct=tel_direct;
            this.Gsm_direct=gsm_direct;
        }
        public Directeur()
        {

        }
        //Méthodes:
        public void Ajouter()
        {

            string req = "INSERT INTO Directeur(CODE_DIRECTEUR,NOM_DIRECT, PRENOM_DIRECT, TEL_DIRECT, GSM_DIRECT ) VALUES( @p1,@p2,@p3,@p4,@p5); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_directeur);
            SqlParameter p2 = new SqlParameter("@p2", this.Nom_direct);
            SqlParameter p3 = new SqlParameter("@p3", this.Prenom_direct);
            SqlParameter p4 = new SqlParameter("@p4", this.Tel_direct);
            SqlParameter p5 = new SqlParameter("@p5", this.Gsm_direct);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);

            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  Directeur  set  NOM_DIRECT=@p2, PRENOM_DIRECT=@p3, TEL_DIRECT=@p4, GSM_DIRECT=@p5 where  CODE_DIRECTEUR=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_directeur);
            SqlParameter p2 = new SqlParameter("@p2", this.Nom_direct);
            SqlParameter p3 = new SqlParameter("@p3", this.Prenom_direct);
            SqlParameter p4 = new SqlParameter("@p4", this.Tel_direct);
            SqlParameter p5 = new SqlParameter("@p5", this.Gsm_direct);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {
            string req = "Delete from  Directeur where  CODE_DIRECTEUR=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_directeur);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }

    }
}
