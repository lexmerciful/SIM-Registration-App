using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Reg
{
    public partial class Homepage : MaterialSkin.Controls.MaterialForm
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnceateAcc_Click(object sender, EventArgs e)
        {
            CreateAcc lex = new CreateAcc();
            lex.ShowDialog();
        }

        private void btnloginUser_Click(object sender, EventArgs e)
        {
            Login lex = new Login();
            lex.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
