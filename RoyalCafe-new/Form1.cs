using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoyalCafe_new.Usercontrols;

namespace RoyalCafe_new
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*if (txtUserName != null && txtPassword != null)
            {
                if (txtUserName.Text == "User" && txtPassword.Text == "password")
                {
                    Dashboard ds = new Dashboard();
                    ds.Show();
                    this.Hide();
                }
            }*/

            string qry = "SELECT * FROM tbLogin WHERE UName = '" + txtUserName.Text + "' AND Pword = '" + txtPassword.Text + "'";

            Connect connect = new Connect();
            DataSet ds = connect.getData(qry);

            if (ds.Tables[0].Rows.Count > 0)
            {
               // MessageBox.Show("Login Successful!");


                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
