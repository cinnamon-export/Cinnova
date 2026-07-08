using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cinnova.Forms
{
    public partial class Dashboardform : Form
    {
        private string _username;
        private string _role;
        public Dashboardform(string username , string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
        }

        private void Dashboardform_Load(object sender, EventArgs e)
        {
            //lblWelcome.Text = "Welcome," + _username + "(" + _role + ")";
        }
    }
}
