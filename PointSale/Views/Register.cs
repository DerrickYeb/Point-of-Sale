using PointSale.Data;
using PointSale.Models;
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
        private Users user = new Users();
        private Controller controller = new Controller();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            bool success = controller.AddUser(user);

            if (txtPassword.Text != txtConfrimPassword.Text)
            {
                MessageBox.Show("Password does not match");
                txtConfrimPassword.Focus();
                return;
            }
            else if(String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Empty fields");
                txtUsername.Focus();
                return;
            }
            else if (success == true)
            {
                MessageBox.Show("User added");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtUsername.Text,"^[a-zA-Z]"))
            {
                MessageBox.Show("Texts only");
               
                txtUsername.Text = string.Empty;
            }
        }
    }
}
