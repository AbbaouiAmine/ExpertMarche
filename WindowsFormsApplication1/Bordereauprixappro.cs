using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Bordereauprixappro
    {
        //Attributs
        private string code_bordureauprixappro;
        private int n_attache;
        private int n_prixappro;
        private double quantite;
        //Getters & Setters
        public string Code_bordureauprixappro
        {
            get { return code_bordureauprixappro; }
            set { code_bordureauprixappro = value; }
        }
        public int N_attache
        {
            get { return n_attache; }
            set { n_attache = value; }
        }
        public int N_prixappro
        {
            get { return n_prixappro; }
            set { n_prixappro = value; }
        }
        public double Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }
        //Constructeurs
        public Bordereauprixappro()
        {

        }
        public Bordereauprixappro(string code_bordureauprixappro, int n_attache, int n_prixappro, double quantite)
        {
            this.Code_bordureauprixappro = code_bordureauprixappro;
            this.N_attache = n_attache;
            this.N_prixappro = n_prixappro;
            this.Quantite = quantite;
        }
        //Destructeur
        ~Bordereauprixappro()
        {

        }
        //Méthodes
        public void Ajouter()
        {

            string req = "INSERT INTO BORDUREAUPRIXAPPRO( Code_BO_PRIX_APPRO, N_ATTACHE, N_PRIXAPPRO, QUANTITE) VALUES( @p1,@p2,@p3,@p4); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_bordureauprixappro);
            SqlParameter p2 = new SqlParameter("@p2", this.N_attache);
            SqlParameter p3 = new SqlParameter("@p3", this.N_prixappro);
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

            string req = "Update  BORDUREAUPRIXAPPRO set N_ATTACHE=@p2, N_PRIXAPPRO=@p3, QUANTITE=@p4 where CODE_BORDUREAUPRIXAPPRO=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_bordureauprixappro);
            SqlParameter p2 = new SqlParameter("@p2", this.N_attache);
            SqlParameter p3 = new SqlParameter("@p3", this.N_prixappro);
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
            string req = "Delete from  BORDUREAUPRIXAPPRO where  CODE_BORDUREAUPRIXAPPRO=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_bordureauprixappro);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
    }
}
