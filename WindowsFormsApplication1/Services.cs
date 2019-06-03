using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApplication1
{
    class Services
    {
        public static bool aff=false;
        public static int c = -1;
        public static DataTable selectTable(string table)
        {
            DataTable dt = new DataTable();
            Services.con.Open();
            string req = "select * from " + table;
            //SqlParameter p1 = new SqlParameter("@a",table1);
            SqlCommand cmd = new SqlCommand(req, Services.con);
            //cmd.Parameters.Add(p1);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            Services.con.Close();
            return dt;
        }
        public static DataTable executeQuery(string query)
        {
            DataSet dt = new DataSet();
            SqlDataAdapter sd = new SqlDataAdapter(query, Services.con);
            sd.Fill(dt, "Table1");
            return dt.Tables["Table1"];
        }
        public static DataTable table;
        public static SqlConnection con = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=gestionMarche;Integrated Security=True");
        public static int Recherche(string code, string table)
        {
            string req = "select * from " + table;
            SqlCommand cmd = new SqlCommand(req, Services.con);
            SqlDataReader dr;
            Services.con.Open();
            dr = cmd.ExecuteReader();
            int pos = -1;
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString().Equals(code))
                {
                    pos = i;
                }
            }
            dr.Close();
            Services.con.Close();
            return pos;
        }
        public static void comboBoxRemplissage(ref ComboBox co, String table1, string Member, string Val)
        {
            try
            {
                Services.con.Open();
                string req = "select * from " + table1;
                //SqlParameter p1 = new SqlParameter("@a",table1);
                SqlCommand cmd = new SqlCommand(req, Services.con);
                //cmd.Parameters.Add(p1);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                co.DataSource = dt;
                co.ValueMember = Val;
                co.DisplayMember = Member;
                Services.con.Close();
            }
            catch (Exception)
            {
                Services.con.Close();
            }
        }
        public static void comboBoxRemplissageData(ref ComboBox co, String req, string Member, string Val)
        {
            try
            {
                co.DataSource = Services.executeQuery(req);
                co.ValueMember = Val;
                co.DisplayMember = Member;
            }
            catch (Exception)
            {

            }
        }
        public static void coloriser(int coleur, Panel a)
        {
            Color temp = Color.FromArgb(coleur);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);
            a.BackColor = result;
        }
        public static void coloriser(int coleur, Button a)
        {
            Color temp = Color.FromArgb(coleur);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);
            a.BackColor = result;
        }
        public static void coloriser(int coleur, Form a)
        {
            Color temp = Color.FromArgb(coleur);
            Color result = Color.FromArgb(temp.R, temp.G, temp.B);
            a.BackColor = result;
        }
        public static void listViewremplissage(ref ListView l, DataTable t)
        {
            l.Items.Clear();
            for (int i = 0; i < t.Rows.Count; i++)
            {
                ListViewItem il = new ListViewItem(t.Rows[i][0].ToString());
                il.SubItems.Add(t.Rows[i][1].ToString());
                il.SubItems.Add(t.Rows[i][2].ToString());
                il.SubItems.Add(t.Rows[i][3].ToString());
                l.Items.Add(il);
            }
        }

    }
}
