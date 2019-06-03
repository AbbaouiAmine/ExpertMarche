using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Attachement
    {
        //Attributs
        
        private string code_attachement;
        private DateTime date_attachement;
        //Getters & Setters
        public string Code_attachement
        {
            get { return code_attachement; }
            set { code_attachement = value; }
        }


        public DateTime Date_attachement
        {
            get { return date_attachement; }
            set { date_attachement = value; }
        }
        //Constructeurs
        public Attachement()
        {

        }
        public Attachement(string code_attachement, DateTime date_attachement)
        {
            this.Code_attachement = code_attachement;
            this.Date_attachement = date_attachement;
        }
        //Destructeur
        ~Attachement()
        {

        }
        //Méthodes 
        public void Ajouter()
        {

            string req = "INSERT INTO ATTACHEMENTS(CODE_ATTACHE, DATEATT) VALUES( @p1,@p2); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_attachement);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_attachement);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Modifier()
        {

            string req = "Update  ATTACHEMENTS set  DATEATT=@p2 where  CODE_ATTACHE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_attachement);
            SqlParameter p2 = new SqlParameter("@p2", this.Date_attachement);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            Services.con.Open();
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
        public void Supprimer()
        {
            string req = "Delete from  ATTACHEMENTS where  CODE_ATTACHE=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_attachement);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
    }
}
