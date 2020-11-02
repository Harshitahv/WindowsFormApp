using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginPage.Forms
{
    public partial class HomeFrom : Form
    {
        public static string Message { get; set; }
        public HomeFrom()
        {
            InitializeComponent();

        }

        private void HomeFrom_Load(object sender, EventArgs e)
        {
            lblMessage.Text = Message;
        }
    }
       
}
