using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Decompte
    {
        //Attributs
        private int n_decompte;
        private string code_decompte;
        private DateTime date_decompte;
        //Getters & Setters
        public int N_decompte
        {
            get { return n_decompte; }
            set { n_decompte = value; }
        }
        public string Code_decompte
        {
            get { return code_decompte; }
            set { code_decompte = value; }
        }
        public DateTime Date_decompte
        {
            get { return date_decompte; }
            set { date_decompte = value; }
        }
        //Constructeurs
        public Decompte()
        {

        }
        public Decompte(string code_decompte, DateTime date_decompte)
        {
            this.Code_decompte = code_decompte;
            this.Date_decompte = date_decompte;
        }
        //Destructeur
        ~Decompte()
        {

        }
        //Méthodes 
        public void Ajouter()
        {

            string req = "INSERT INTO Decompte(N_DECOMPTE,CODE_DECOMPTE, DATE_DECOMPTE) VALUES(@p1,@p2,@p3);";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_decompte);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_decompte);
            SqlParameter p3 = new SqlParameter("@p3", this.Date_decompte);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  Decompte set  DATE_DECOMPTE=@p2 where  CODE_DECOMPTE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_decompte);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_decompte);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {
            string req = "Delete from  Decompte where  CODE_DECOMPTE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_decompte);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
    }
}
