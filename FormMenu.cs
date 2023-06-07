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
    public partial class FormMenu : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }
        public FormMenu()
        {
            InitializeComponent();
        }

        public event EventHandler DangXuat;
        private void logoutButton_Click(object sender, EventArgs e)
        {
            DangXuat?.Invoke(this, EventArgs.Empty);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            timeLabel.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void buttonCIP_Click(object sender, EventArgs e)
        {
            FormCIP cip = new FormCIP();
            cip.ShowDialog();
        }
    }
}
