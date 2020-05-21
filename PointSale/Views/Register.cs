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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtConfrimPassword.Text)
            {
                MessageBox.Show("Password does not match");
                txtConfrimPassword.Focus();
                return;
            }
        }
    }
}
