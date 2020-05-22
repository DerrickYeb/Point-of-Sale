using PointSale.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointSale.Data
{
    public class Controller
    {
        private DataConnection connection = new DataConnection();

        #region Add User
        bool success = false;

        public bool AddUser(Users users)
        {
            connection = new DataConnection();
            connection.MyConnection();

            try
            {
                connection.SqlQuery("Insert into [Users] (Username,Password) Values(@username,@password)");
                connection.sqlCommand.Parameters.AddWithValue("@username", users.Username);
                connection.sqlCommand.Parameters.AddWithValue("@password", users.Password);
                int row = connection.sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return success;
        }
        #endregion
    }
}
