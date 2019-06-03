using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Diriger
    {
        //Attributs
            private int n_dirige;
            private string  code_dirige;
            private DateTime  date_deb;
            private DateTime date_fin;
            private int  direct;
            private int direction;
        //Getters & Setters
            public int N_dirige
            {
                get { return n_dirige; }
                set { n_dirige = value; }
            }
            public string Code_dirige
            {
                get { return code_dirige; }
                set { code_dirige = value; }
            }
            public DateTime Date_deb
            {
                get { return date_deb; }
                set { date_deb = value; }
            }
            public DateTime Date_fin
            {
                get { return date_fin; }
                set { date_fin = value; }
            }
            public int Direct
            {
                get { return direct; }
                set { direct = value; }
            }
            public int Direction
            {
                get { return direction; }
                set { direction = value; }
            }
        //Constructeurs
            public Diriger()
            {

            }
            public Diriger( string  code_dirige, DateTime  date_deb, DateTime date_fin, int  direct, int  direction)
            {
                this.Code_dirige=code_dirige;
                this.Date_deb=date_deb;
                this.Date_fin=date_fin;
                this.Direct=direct;
                this.Direction=direction;    
            }
        //Méthodes
            public void Ajouter()
            {

                string req = "INSERT INTO Diriger( CODE_DIRIGE, DATE_DEB, DATE_FIN, DIRECT, DIRECTION ) VALUES( @p1,@p2,@p3,@p4,@p5); ";
                SqlParameter p1 = new SqlParameter("@p1", this.Code_dirige);
                SqlParameter p2 = new SqlParameter("@p2", this.Date_deb);
                SqlParameter p3 = new SqlParameter("@p3", this.Date_fin);
                SqlParameter p4 = new SqlParameter("@p4", this.Direct);
                SqlParameter p5 = new SqlParameter("@p5", this.Direction);
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

                string req = "Update  Diriger  set ( DATE_DEB=@p2, DATE_FIN=@p3, DIRECT=@p4, DIRECTION=@p5) where  CODE_DIRIGE=@p1";
                SqlParameter p1 = new SqlParameter("@p1", this.Code_dirige);
                SqlParameter p2 = new SqlParameter("@p2", this.Date_deb);
                SqlParameter p3 = new SqlParameter("@p3", this.Date_fin);
                SqlParameter p4 = new SqlParameter("@p4", this.Direct);
                SqlParameter p5 = new SqlParameter("@p5", this.Direction);
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
                string req = "Delete from  Diriger where  CODE_DIRIGE=@p1";
                SqlParameter p1 = new SqlParameter("@p1", this.Code_dirige);
                SqlCommand cmd = new SqlCommand(req, Services.con);
                cmd.Parameters.Add(p1);
                Services.con.Open();
                cmd.ExecuteNonQuery();
                Services.con.Close();
            }

    }
}
