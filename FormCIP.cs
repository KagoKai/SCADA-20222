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
    public partial class FormCIP : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }
        public FormCIP()
        {
            InitializeComponent();
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
