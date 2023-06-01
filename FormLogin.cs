using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu f = new FormMenu();
            f.Show();
            f.DangXuat += F_DangXuat;
        }

        public void F_DangXuat(object sender, EventArgs e)
        {
            this.Show();
            (sender as FormMenu).Close();
        }
    }
}
