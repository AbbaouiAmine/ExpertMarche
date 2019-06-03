using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class MarchésP
    {
        //Attribues
        private int n_marche;
        private string code_marche;
        private string annee;
        private string objet;
        private string type_prestation;
        private int prest;
        private DateTime date_debut;
        private double delai;
        private DateTime date_fin_realisation;
        private double montant_engage;
        //Getters & Setters
        public int N_marche
        {
            get { return n_marche; }
            set { n_marche = value; }
        }
        public string Code_marche
        {
            get { return code_marche; }
            set { code_marche = value; }
        }
        public string Annee
        {
            get { return annee; }
            set { annee = value; }
        }
        public string Objet
        {
            get { return objet; }
            set { objet = value; }
        }
        public string Type_prestation
        {
            get { return type_prestation; }
            set { type_prestation = value; }
        }
        public int Prest
        {
            get { return prest; }
            set { prest = value; }
        }
        public DateTime Date_debut
        {
            get { return date_debut; }
            set { date_debut = value; }
        }
        public double Delai
        {
            get { return delai; }
            set { delai = value; }
        }
        public DateTime Date_fin_realisation
        {
            get { return date_fin_realisation; }
            set { date_fin_realisation = value; }
        }
        public double Montant_engage
        {
            get { return montant_engage; }
            set { montant_engage = value; }
        }
        //Constructeurs
        public MarchésP()
        {

        }
        public MarchésP(string code_marche, string annee, string objet,  string type_prestation, int prest, DateTime date_debut, double delai, DateTime date_fin_realisation, double montant_engage	)
        {
            this.Code_marche = code_marche;
            this.Annee = annee;
            this.Objet = objet;
            this.Type_prestation = type_prestation;
            this.Prest = prest;
            this.Date_debut = date_debut;
            this.Delai = delai;
            this.Date_fin_realisation=date_fin_realisation;
            this.Montant_engage = montant_engage;
        }
        
        //Méthodes:
        public void Ajouter()
        {

            string req = "INSERT INTO MARCHESP(CODE_MARCHE, ANNEE, OBJET, TYPE_PRESTATION, PREST, DATE_DEBUT, DELAI, DATE_FIN_REALISATION, MONTANT_ENGAGE ) VALUES( @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_marche);
            SqlParameter p2 = new SqlParameter("@p2", this.Annee);
            SqlParameter p3 = new SqlParameter("@p3", this.Objet);
            SqlParameter p4 = new SqlParameter("@p4", this.Type_prestation);
            SqlParameter p5 = new SqlParameter("@p5", this.Prest);
            SqlParameter p6 = new SqlParameter("@p6", this.Date_debut);
            SqlParameter p7 = new SqlParameter("@p7", this.Delai);
            SqlParameter p8 = new SqlParameter("@p8", this.Date_fin_realisation);
            SqlParameter p9 = new SqlParameter("@p9", this.Montant_engage);
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

            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  MARCHESP  set ( ANNEE=@p2, OBJET=@p3, TYPE_PRESTATION=@p4, PREST=@p5, DATE_DEBUT=@p6, DELAI=@p7, DATE_FIN_REALISATION=@p8, MONTANT_ENGAGE=@p9) where   CODE_MARCHE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_marche);
            SqlParameter p2 = new SqlParameter("@p2", this.Annee);
            SqlParameter p3 = new SqlParameter("@p3", this.Objet);
            SqlParameter p4 = new SqlParameter("@p4", this.Type_prestation);
            SqlParameter p5 = new SqlParameter("@p5", this.Prest);
            SqlParameter p6 = new SqlParameter("@p6", this.Date_debut);
            SqlParameter p7 = new SqlParameter("@p7", this.Delai);
            SqlParameter p8 = new SqlParameter("@p8", this.Date_fin_realisation);
            SqlParameter p9 = new SqlParameter("@p9", this.Montant_engage);
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
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {
            string req = "Delete from MARCHESP where  CODE_MARCHE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_marche);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }

    }
}
