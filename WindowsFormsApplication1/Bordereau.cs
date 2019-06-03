using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Bordereau
    {
        //Attributs
        private string code_brd;
        private DateTime date_bord;
        private double quantite;
        private double prix_un;
        private int n_marche;
        private int n_prix;
        //Getters & Setters
        public string Code_brd
        {
            get { return code_brd; }
            set { code_brd = value; }
        } 
        public DateTime Date_bord
        {
            get { return date_bord; }
            set { date_bord = value; }
        }
        public double Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        public double Prix_un
        {
            get { return prix_un; }
            set { prix_un = value; }
        }
        public int N_marche
        {
            get { return n_marche; }
            set { n_marche = value; }
        }
        public int N_prix
        {
            get { return n_prix; }
            set { n_prix = value; }
        }
        //Constructeurs
        public Bordereau()
        {
          
        }
        public Bordereau(string code_brd,DateTime date_bord, double quantite,double prix_un, int n_marche,int n_prix)
        {
            this.Code_brd = code_brd;
            this.Date_bord = date_bord;
            this.Quantite = quantite;
            this.Prix_un = prix_un;
            this.N_marche = n_marche;
            this.N_prix = n_prix;
        }
        //Destructeur
        ~Bordereau()
        {

        }
        //Méthodes
        public void Ajouter()
        {

            string req = "INSERT INTO BORDERAUX_DETAIL( CODE_BRD, DATE_BORD, QUANTITE, PRIX_UN, N_MARCHE, N_PRIX ) VALUES( @p1,@p2,@p3,@p4,@p5,@p6); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_brd);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_bord);
            SqlParameter p3 = new SqlParameter("@p3", this.Quantite);
            SqlParameter p4 = new SqlParameter("@p4", this.Prix_un);
            SqlParameter p5 = new SqlParameter("@p5", this.N_marche);
            SqlParameter p6 = new SqlParameter("@p6", this.N_prix);
            

            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);

            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  BORDERAUX_DETAIL  set DATE_BORD=@p2, QUANTITE=@p3, PRIX_UN=@p4, N_MARCHE=@p5, N_PRIX=@p6   where CODE_BRD=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_brd);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_bord);
            SqlParameter p3 = new SqlParameter("@p3", this.Quantite);
            SqlParameter p4 = new SqlParameter("@p4", this.Prix_un);
            SqlParameter p5 = new SqlParameter("@p5", this.N_marche);
            SqlParameter p6 = new SqlParameter("@p6", this.N_prix);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {
            string req = "Delete from  BORDERAUX_DETAIL where  CODE_BRD=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_brd);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
    }
}
