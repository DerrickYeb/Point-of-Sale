using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSale.Data
{
   public class DataConnection
    {
        public SqlConnection sqlConnection = new SqlConnection();
        public SqlCommand sqlCommand = new SqlCommand();
        static string POS;
        public void MyConnection()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
                using (sqlCommand = new SqlCommand($"If(db_id(N'POS') IS NULL) CREATE DATABASE [POS]",sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
        public void SqlQuery(string query)
        {
            sqlCommand = new SqlCommand(query, sqlConnection);
        }
        public void NonExecuteQuery()
        {
            sqlCommand.ExecuteNonQuery();
        }
    }
}
