using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Ordre_Service
    {
        //Attribues
        private int n_ordre;
        private string code_ordre;
        private DateTime date_ordre;
        private string objet_ordre;
        private string type_ordre;
        private int chef_service;
        private int marche;
        private int directeur;
        //Getters & Setters
        public int N_ordre
        {
            get { return n_ordre; }
            set { n_ordre = value; }
        }
        public string Code_ordre
        {
            get { return code_ordre; }
            set { code_ordre = value; }
        }
        public DateTime Date_ordre
        {
            get { return date_ordre; }
            set { date_ordre = value; }
        }
        public string Objet_ordre
        {
            get { return objet_ordre; }
            set { objet_ordre = value; }
        }
        public string Type_ordre
        {
            get { return type_ordre; }
            set { type_ordre = value; }
        }
        public int Chef_service
        {
            get { return chef_service; }
            set { chef_service = value; }
        }
        public int Marche
        {
            get { return marche; }
            set { marche = value; }
        }
        public int Directeur
        {
            get { return directeur; }
            set { directeur = value; }
        }
        
        //Constructeurs
        public Ordre_Service()
        {

        }
        public Ordre_Service(string code_ordre, DateTime date_ordre, string objet_ordre, string type_ordre, int chef_service, int marche, int directeur)
        {
            this.Code_ordre = code_ordre;
            this.Date_ordre = date_ordre;
            this.Objet_ordre = objet_ordre;
            this.Type_ordre = type_ordre;
            this.Chef_service = chef_service;
            this.Marche = marche;
            this.Directeur = directeur;  
        }
        //Méthodes:
        public void Ajouter()
        {

            string req = "INSERT INTO Ordre_Service( CODE_ORDRE, DATE_ORDRE, OBJET_ORDRE, TYPE_ORDRE, CHEF_SERVICE, MARCHE, DIRECTEUR ) VALUES( @p1,@p2,@p3,@p4,@p5,@p6,@p7); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_ordre);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_ordre);
            SqlParameter p3 = new SqlParameter("@p3", this.Objet_ordre);
            SqlParameter p4 = new SqlParameter("@p4", this.Type_ordre);
            SqlParameter p5 = new SqlParameter("@p5", this.Chef_service);
            SqlParameter p6 = new SqlParameter("@p6", this.Marche);
            SqlParameter p7 = new SqlParameter("@p7", this.Directeur);

            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);

            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  Ordre_Service  set ( DATE_ORDRE=@p2, OBJET_ORDRE=@p3, TYPE_ORDRE=@p4, CHEF_SERVICE=@p5, MARCHE=@p6, DIRECTEUR=@p7  ) where CODE_ORDRE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_ordre);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_ordre);
            SqlParameter p3 = new SqlParameter("@p3", this.Objet_ordre);
            SqlParameter p4 = new SqlParameter("@p4", this.Type_ordre);
            SqlParameter p5 = new SqlParameter("@p5", this.Chef_service);
            SqlParameter p6 = new SqlParameter("@p6", this.Marche);
            SqlParameter p7 = new SqlParameter("@p7", this.Directeur);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {
            string req = "Delete from  Ordre_Service where  CODE_ORDRE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_ordre);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        


    }
}
