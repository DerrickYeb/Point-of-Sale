using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointSale.Views
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }
        public async Task GetAutoCompleTeDataAsync()
        {

            string connection = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            string query = ("Select ProductName from Product");

            using (SqlConnection conn = new SqlConnection(connection))
            {

                SqlCommand cmd = new SqlCommand(query, conn);

                await conn.OpenAsync();


                using (SqlDataReader dr = await cmd.ExecuteReaderAsync())
                {
                    AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                    while (await dr.ReadAsync())
                    {
                        collection.Add(dr.GetString(0));


                    }
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        txtSearchBox.AutoCompleteCustomSource = collection;
                    }));


                    dr.Close();
                }
                conn.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
