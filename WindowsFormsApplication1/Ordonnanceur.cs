using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Ordonnanceur
    {
        
        private int n_ordonnanceur;
        private string code_ordonnanceur;
        private string nom_ordo;
        private string prenomordo;
        private string qualite;

        public int N_ordonnanceur
        {
            get { return n_ordonnanceur; }
            set { n_ordonnanceur = value; }
        }
        public string Code_ordonnanceur
        {
            get { return code_ordonnanceur; }
            set { code_ordonnanceur = value; }
        }
        public string Nom_ordo
        {
            get { return nom_ordo; }
            set { nom_ordo = value; }
        }
        public string Prenomordo
        {
            get { return prenomordo; }
            set { prenomordo = value; }
        }
        public string Qualite
        {
            get { return qualite; }
            set { qualite = value; }
        }
        //Constructeurs
        public Ordonnanceur()
        {

        }
        public Ordonnanceur( string code_ordonnanceur, string nom_ordo, string prenomordo, string qualite)
        {
            this.Code_ordonnanceur = code_ordonnanceur;
            this.Nom_ordo = nom_ordo;
            this.Prenomordo = prenomordo;
            this.Qualite = qualite;
        }
        //Méthodes:
        public void Ajouter()
        {

            string req = "INSERT INTO Ordonnanceur( CODE_ORDONNANCEUR, NOM_ORDO, PRENOMORDO, QUALITE) VALUES( @p1,@p2,@p3,@p4); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_ordonnanceur);
            SqlParameter p2 = new SqlParameter("@p2", this.Nom_ordo);
            SqlParameter p3 = new SqlParameter("@p3", this.Prenomordo);
            SqlParameter p4 = new SqlParameter("@p4", this.Qualite);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
         
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  Ordonnanceur set  NOM_ORDO=@p2, PRENOMORDO=@p3, QUALITE=@p4 where CODE_ORDONNANCEUR=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_ordonnanceur);
            SqlParameter p2 = new SqlParameter("@p2", this.Nom_ordo);
            SqlParameter p3 = new SqlParameter("@p3", this.Prenomordo);
            SqlParameter p4 = new SqlParameter("@p4", this.Qualite);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {
            string req = "Delete from  Ordonnanceur where  CODE_ORDONNANCEUR=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_ordonnanceur);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }



    }
}
