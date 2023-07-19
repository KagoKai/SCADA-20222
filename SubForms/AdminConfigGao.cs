using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.SubForms
{
    public partial class AdminConfigGao : Form
    {
        public AdminConfigGao()
        {
            InitializeComponent();
        }

        private void AdminConfigGao_Load(object sender, EventArgs e)
        {
            //V13_switchTimes.Text = Noi_gao.s_V13_switchCount.ToString();
            //V14_switchTimes.Text = Noi_gao.s_V14_switchCount.ToString();
            //V17_switchTimes.Text = Noi_gao.s_V17_switchCount.ToString();

            Binding bind_V13_switchCount = new Binding("Text", FormMenu.s_switchCount, "V13D_switchCount", true, DataSourceUpdateMode.OnPropertyChanged);
            V13_switchTimes.DataBindings.Add(bind_V13_switchCount);
            Binding bind_V14_switchCount = new Binding("Text", FormMenu.s_switchCount, "V14D_switchCount", true, DataSourceUpdateMode.OnPropertyChanged);
            V14_switchTimes.DataBindings.Add(bind_V14_switchCount);
            Binding bind_V17_switchCount = new Binding("Text", FormMenu.s_switchCount, "V17D_switchCount", true, DataSourceUpdateMode.OnPropertyChanged);
            V17_switchTimes.DataBindings.Add(bind_V17_switchCount);
        }

        private void switchTimeLimitSet_Click(object sender, EventArgs e)
        {
            ushort x;
            if (UInt16.TryParse(TxtSwitchTimeLimit.Text, out x) && (x < 1000))
            {
                Noi_gao.s_maxSwitchCount = x;
            }
            else
            {
                MessageBox.Show("Chỉ được nhập số nguyên dương nhỏ hơn 100 !");
            }
        }

        private void V13_switchTimesReset_Click(object sender, EventArgs e)
        {
            FormMenu.s_switchCount.V13D_switchCount = 0;
        }

        private void V14_switchTimesReset_Click(object sender, EventArgs e)
        {
            FormMenu.s_switchCount.V14D_switchCount = 0;
        }

        private void V17_switchTimesReset_Click(object sender, EventArgs e)
        {
            FormMenu.s_switchCount.V17D_switchCount = 0;
        }
    }
}
