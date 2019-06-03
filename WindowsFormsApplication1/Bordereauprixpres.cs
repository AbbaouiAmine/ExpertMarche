using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Bordereauprixpres
    {
        //Attributs
        private string code_bordureauprixpres;
        private int n_attache;
        private int n_prixpres;
        private double quantite;
        //Getters & Setters
        public string Code_bordureauprixpres
        {
            get { return code_bordureauprixpres; }
            set { code_bordureauprixpres = value; }
        }
        public int N_attache
        {
            get { return n_attache; }
            set { n_attache = value; }
        }
        public int N_prixpres
        {
            get { return n_prixpres; }
            set { n_prixpres = value; }
        }
        public double Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        //Constructeurs
        public Bordereauprixpres()
        {

        }
        public Bordereauprixpres(string code_bordureauprixpres, int n_attache, int n_prixpres, double quantite)
        {
            this.Code_bordureauprixpres = code_bordureauprixpres;
            this.N_attache = n_attache;
            this.N_prixpres = n_prixpres;
            this.Quantite = quantite;
        }
        //Destructeur
        ~Bordereauprixpres()
        {

        }
        //Méthodes
        public void Ajouter()
        {

            string req = "INSERT INTO BORDUREAUPRIXPRES( CODE_BORDUREAUPRIXPRES, N_ATTACHE, N_PRIXPRES, QUANTITE) VALUES( @p1,@p2,@p3,@p4); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_bordureauprixpres);
            SqlParameter p2 = new SqlParameter("@p2", this.N_attache);
            SqlParameter p3 = new SqlParameter("@p3", this.N_prixpres);
            SqlParameter p4 = new SqlParameter("@p4", this.Quantite);
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

            string req = "Update  BORDUREAUPRIXPRES set N_ATTACHE=@p2, N_PRIXPRES=@p3, QUANTITE=@p4 where CODE_BORDUREAUPRIXPRES=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_bordureauprixpres);
            SqlParameter p2 = new SqlParameter("@p2", this.N_attache);
            SqlParameter p3 = new SqlParameter("@p3", this.N_prixpres);
            SqlParameter p4 = new SqlParameter("@p4", this.Quantite);
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
            string req = "Delete from  BORDUREAUPRIXPRES where  CODE_BORDUREAUPRIXPRES=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_bordureauprixpres);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }

    }
}
