using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Direction
    {
        private string n_direc;
        private string code_direc;
        private string type_direc;
        private string ville;
        private string region;
        //Getters & Setters
        public string N_direc
        {
            get { return n_direc; }
            set { n_direc = value; }
        }
        public string Code_direc
        {
            get { return code_direc; }
            set { code_direc = value; }
        }
        public string Type_direc
        {
            get { return type_direc; }
            set { type_direc = value; }
        }
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        //Constructeur
        public Direction()
        {

        }
        public Direction(string code_direc, string type_direc, string ville, string region)
        {
            this.Code_direc = code_direc;
            this.Type_direc = type_direc;
            this.Ville = ville;
            this.Region = region;
        }
        ~Direction()
        {

        }
        //Méthodes :
        public void Ajouter()
        {

            string req = "INSERT INTO Directions( CODE_DIREC, TYPE_DIREC, VILLE, REGION) VALUES( @p1,@p2,@p3,@p4); ";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_direc);
            SqlParameter p2 = new SqlParameter("@p2", this.Type_direc);
            SqlParameter p3 = new SqlParameter("@p3", this.Ville);
            SqlParameter p4 = new SqlParameter("@p4", this.Region);
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

            string req = "Update  Directions set TYPE_DIREC=@p2, VILLE=@p3, REGION=@p4  where  CODE_DIREC=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_direc);
            SqlParameter p2 = new SqlParameter("@p2", this.Type_direc);
            SqlParameter p3 = new SqlParameter("@p3", this.Ville);
            SqlParameter p4 = new SqlParameter("@p4", this.Region);
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
            string req = "Delete from  Directions where CODE_DIREC=@p1";
            SqlParameter p1 = new SqlParameter("@p1", this.Code_direc);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            cmd.Parameters.Add(p1);
            Services.con.Open();
            cmd.ExecuteNonQuery();
            Services.con.Close();
        }
    }
}
