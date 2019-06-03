using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Prixappro
    {
        //Attributs
        private string code_prixappro;
        private int px_n;
        private string ref_cps_cpc;
        private string desig;
        private string unite_mesure;
        private double prix_un;

       
        //Getters & Setters
        public string Code_prixappro
        {
            get { return code_prixappro; }
            set { code_prixappro = value; }
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
        public double Prix_un
        {
            get { return prix_un; }
            set { prix_un = value; }
        }
        //Constructeurs
        public Prixappro()
        {

        }
        public Prixappro(string code_prixappro, int px_n, string ref_cps_cpc, string desig, string unite_mesure,double prix_un)
        {
            this.Code_prixappro = code_prixappro;
            this.Px_n = px_n;
            this.Ref_cps_cpc = ref_cps_cpc;
            this.Desig = desig;
            this.Unite_mesure = unite_mesure;
            this.Prix_un = prix_un;
        }
        //Destructeur
        ~Prixappro()
        {

        }
        //Méthodes
        public void Ajouter()
        {
            string req = "INSERT INTO PRIXAPPRO(CODE_PRIXAPPRO, PX_N, REF_CPS_CPC, DESIG, UNITE_MESURE,PRIX_UN) VALUES( @p1,@p2,@p3,@p4,@p5,@p6); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prixappro);
            SqlParameter p2 = new SqlParameter("@p2", this.Px_n);
            SqlParameter p3 = new SqlParameter("@p3", this.Ref_cps_cpc);
            SqlParameter p4 = new SqlParameter("@p4", this.Desig);
            SqlParameter p5 = new SqlParameter("@p5", this.Unite_mesure);
            SqlParameter p6 = new SqlParameter("@p6", this.Prix_un);
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
            string req = "Update  PRIXAPPRO  set  PX_N=@p2, REF_CPS_CPC=@p3, DESIG=@p4, UNITE_MESURE=@p5,PRIX_UN=@p6 where  CODE_PRIXAPPRO=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prixappro);
            SqlParameter p2 = new SqlParameter("@p2", this.Px_n);
            SqlParameter p3 = new SqlParameter("@p3", this.Ref_cps_cpc);
            SqlParameter p4 = new SqlParameter("@p4", this.Desig);
            SqlParameter p5 = new SqlParameter("@p5", this.Unite_mesure);
            SqlParameter p6 = new SqlParameter("@p6", this.Prix_un);
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
            string req = "Delete from  PRIXAPPRO where  CODE_PRIXAPPRO=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_prixappro);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }

    }
}
