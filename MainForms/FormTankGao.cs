using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.MainForms;

namespace test
{
    public partial class Noi_gao : ScadaUI
    {
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }
        public Noi_gao()
        {
            InitializeComponent();
            this.returnButton.Click += base.returnButton_Click;
            this.V13.Click += base.valve_Click;
            this.V14.Click += base.valve_Click;
            this.V17.Click += base.valve_Click;
        }
    }
}
