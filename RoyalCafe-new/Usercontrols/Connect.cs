using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyalCafe_new.Usercontrols
{
    internal class Connect
    {
        public SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-8L6N50O;database = RoyalCafe;integrated security = True";
            return conn;
        }

        public DataSet getData(String qry)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = qry;

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            ad.Fill(ds);
            return ds;

        }

        public void setData(String qry)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data inserted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
