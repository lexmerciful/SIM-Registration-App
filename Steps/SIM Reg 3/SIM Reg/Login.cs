using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SIM_Reg
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Form1.BackColor = Color.Transparent;
            
        }

        private void lbcreatenow_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAcc lex = new CreateAcc();
            lex.ShowDialog();
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Your Username!");
                txtUsername.Focus();
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password!");
                txtPassword.Focus();
            }
        }
    }
}
