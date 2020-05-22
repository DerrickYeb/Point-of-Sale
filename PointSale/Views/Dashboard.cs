using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointSale.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            lblDate.Text = DateTime.UtcNow.ToLongDateString();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var products = new Products();
            products.ShowDialog();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            var pos = new POS();
            pos.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var stock = new Stock();
            stock.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            var sales = new Sales();
            sales.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            var suppliers = new Suppliers();
            suppliers.ShowDialog();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            var pos = new Expenses();
            pos.ShowDialog();
        }
    }
}
