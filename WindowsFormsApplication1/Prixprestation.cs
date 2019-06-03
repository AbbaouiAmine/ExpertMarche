using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Prixprestation
    {
        //Attributs
        private string code_prixpres;
        private int px_n;
        private string ref_cps_cpc;
        private string desig;
        private string unite_mesure;

        //Getters & Setters
        public string Code_prixpres
        {
            get { return code_prixpres; }
            set { code_prixpres = value; }
        }
        public int Px_n
        {
            get { return px_n; }
            set { px_n = value; }
        }
        public string Ref_cps_cpc
        {
            get { return ref_cps_cpc; }
            set { ref_cps_cpc = value; }
        }
        public string Desig
        {
            get { return desig; }
            set { desig = value; }
        }


        public string Unite_mesure
        {
            get { return unite_mesure; }
            set { unite_mesure = value; }
        }

        //Constructeurs
        public Prixprestation()
        {

        }
        public Prixprestation(string code_prixpres, int px_n, string ref_cps_cpc, string desig, string unite_mesure)
        {
            this.Code_prixpres = code_prixpres;
            this.Px_n = px_n;
            this.Ref_cps_cpc = ref_cps_cpc;
            this.Desig = desig;
            this.Unite_mesure = unite_mesure;
        }
        //Destructeur
        ~Prixprestation()
        {

        }
        //Méthodes
        public void Ajouter()
        {

            string req = "INSERT INTO PRIXPRESTATION(CODE_PRIXPRES, PX_N, REF_CPS_CPC, DESIG, UNITE_MESURE) VALUES( @p1,@p2,@p3,@p4,@p5); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prixpres);
            SqlParameter p2 = new SqlParameter("@p2", this.Px_n);
            SqlParameter p3 = new SqlParameter("@p3", this.Ref_cps_cpc);
            SqlParameter p4 = new SqlParameter("@p4", this.Desig);
            SqlParameter p5 = new SqlParameter("@p5", this.Unite_mesure);
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

            string req = "Update  PRIXPRESTATION  set  PX_N=@p2, REF_CPS_CPC=@p3, DESIG=@p4, UNITE_MESURE=@p5 where  CODE_PRIXPRES=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prixpres);
            SqlParameter p2 = new SqlParameter("@p2", this.Px_n);
            SqlParameter p3 = new SqlParameter("@p3", this.Ref_cps_cpc);
            SqlParameter p4 = new SqlParameter("@p4", this.Desig);
            SqlParameter p5 = new SqlParameter("@p5", this.Unite_mesure);
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
            string req = "Delete from  PRIXPRESTATION where  CODE_PRIXPRES=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prixpres);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
    }
}
