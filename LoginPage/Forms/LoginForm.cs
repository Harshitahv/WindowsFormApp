using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LoginPage.Shared;

namespace LoginPage.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Service.LoginUser(txtUserName.Text,txtPassword.Text))
            {
                HomeFrom from = new HomeFrom();
                HomeFrom.Message = "Welcome " + txtUserName.Text;
                from.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials...!");
                Reset();
            }
        }
    }
}
