using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SIM_Reg
{
    public partial class RegisterSIM : MaterialSkin.Controls.MaterialForm
    {
        public RegisterSIM()
        {
            InitializeComponent();
        }

        private void RegisterSIM_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@".\States.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            foreach(string s in y)
            {
                cbStates.Items.Add(s);
            }

        }

        private void cbStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStates.SelectedIndex == 0)
            {
                Abia();
            }

            if (cbStates.SelectedIndex == 1)
            {
                Adamawa();
            }

            if (cbStates.SelectedIndex == 2)
            {
                Abuja();
            }

            if (cbStates.SelectedIndex == 3)
            {
                Akwa_Ibom();
            }

            if (cbStates.SelectedIndex == 4)
            {
                Anambra();
            }
        }

        private void cbStates_TextUpdate(object sender, EventArgs e)
        {
            if (cbStates.Text == "Abia")
            {
                Abia();
            }

            if (cbStates.Text == "Adamawa")
            {
                Adamawa();
            }

            if (cbStates.Text == "Abuja")
            {
                Abuja();
            }

            if (cbStates.Text == "Akwa Ibom")
            {
                Akwa_Ibom();
            }

            if (cbStates.Text == "Akwa Ibom")
            {
                Anambra();
            }
        }

        private void Abia()
        {
            StreamReader sr = new StreamReader(@".\Abia.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            cbLga.Items.Clear();
            foreach (string s in y)
            {
                cbLga.Items.Add(s);
            }
        }

        private void Adamawa()
        {
            StreamReader sr = new StreamReader(@".\Adamawa.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            cbLga.Items.Clear();
            foreach (string s in y)
            {
                cbLga.Items.Add(s);
            }
        }

        private void Abuja()
        {
            StreamReader sr = new StreamReader(@".\Abuja.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            cbLga.Items.Clear();
            foreach (string s in y)
            {
                cbLga.Items.Add(s);
            }
        }

        private void Akwa_Ibom()
        {
            StreamReader sr = new StreamReader(@".\Akwa Ibom.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            cbLga.Items.Clear();
            foreach (string s in y)
            {
                cbLga.Items.Add(s);
            }
        }

        private void Anambra()
        {
            StreamReader sr = new StreamReader(@".\Anambra.txt");
            string x = sr.ReadToEnd();
            string[] y = x.Split('\n');
            cbLga.Items.Clear();
            foreach (string s in y)
            {
                cbLga.Items.Add(s);
            }
        }
    }
}
