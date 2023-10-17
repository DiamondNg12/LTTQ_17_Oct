using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace LTTQ_17_Oct
{
    internal class DatabaseConnection
    {
        SqlConnection connect = new SqlConnection("Data Source=DIAMONDN\\SQLEXPRESS;Initial Catalog=LTTQ_TEMP;User ID=sa;Password=diamond12.ng");

        public void openConnection()
        {
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }
        }

        public void closeConnection()
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }

        }

        public DataTable data(string table)
        {
            this.openConnection();
            DataTable dt = new DataTable();
            string query = "select * from " + table;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, this.connect);
            dataAdapter.Fill(dt);
            this.closeConnection();
            return dt;
        }

        public void executeQuery(string query)
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand(query, this.connect);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            } catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
