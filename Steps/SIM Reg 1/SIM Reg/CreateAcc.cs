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
    public partial class CreateAcc : MaterialSkin.Controls.MaterialForm
    {
        public static MySqlConnection con = new MySqlConnection("user=root;password=;server=localhost;database=user_regdb;");
        //SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd;
        //SqlDataAdapter adapter;
        //DataTable dt = new DataTable();

        public CreateAcc()
        {
            InitializeComponent();
        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lex = new Login();
            lex.ShowDialog();
            this.Close();
        }

        private void btnresgister_Click(object sender, EventArgs e)
        {
            ConfirmEmpty();
            Passwordcheck();
            Add_User();
            Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ConfirmEmpty()
        {
            if (txtFname.Text == "")
            {
                MessageBox.Show("Please Enter Your First Name!");
                txtFname.Focus();
            }

            else if (txtLname.Text == "")
            {
                MessageBox.Show("Please Enter Your Last Name!");
                txtLname.Focus();
            }

            else if (txtUname.Text == "")
            {
                MessageBox.Show("Please Enter Your Username!");
                txtUname.Focus();
            }

            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter Your Email!");
                txtEmail.Focus();
            }

            else if (txtPword.Text == "")
            {
                MessageBox.Show("Please Enter Your Password!");
                txtPword.Focus();
            }

            else if (txtRePword.Text == "")
            {
                MessageBox.Show("Please Enter Your Confirmation Password!");
                txtRePword.Focus();
            }

            else if (txtRecoverQues.Text == "")
            {
                MessageBox.Show("Please Fill In Your Password Recovery Question!");
                txtRecoverQues.Focus();
            }

            else if (txtRecoverAns.Text == "")
            {
                MessageBox.Show("Please Fill In Your Password Recovery Answer!");
                txtRecoverAns.Focus();
            }
        }

        private void Passwordcheck()
        {
            if(txtPword.Text != txtRePword.Text)
            {
                MessageBox.Show("Password does not match!\a");
                txtPword.Focus();
            }
        }

        private void Add_User()
        {
            try
            {
                con.Open();
                string sql = "INSERT INTO users(firstname,lastname,username,email,password,repassword,recoverque,recoverans) value (@firstname,@lastname,@username,@email,@password,@repassword,@recoverque,@recoverans)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@firstname", txtFname.Text.Trim());
                cmd.Parameters.AddWithValue("@lastname", txtLname.Text.Trim());
                cmd.Parameters.AddWithValue("@username", txtUname.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPword.Text.Trim());
                cmd.Parameters.AddWithValue("@repassword", txtRePword.Text.Trim());
                cmd.Parameters.AddWithValue("@recoverque", txtRecoverQues.Text.Trim());
                cmd.Parameters.AddWithValue("@recoverans", txtRecoverAns.Text.Trim());
                cmd.ExecuteNonQuery();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Account Registered Successfully!");

                    lbLogin.Text = "Account Created Successfully, Login Now!";
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Clear()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtUname.Text = "";
            txtEmail.Text = "";
            txtPword.Text = "";
            txtRePword.Text = "";
            txtRecoverQues.Text = "";
            txtRecoverAns.Text = "";
        }

    }
}
