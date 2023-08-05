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
        public event EventHandler WarningReset;
        public event EventHandler DatGioiHan;

        public AdminConfigGao()
        {
            InitializeComponent();
        }

        private void AdminConfigGao_Load(object sender, EventArgs e)
        {
            SwitchCount.Text = Noi_gao.s_maxSwitchCount.ToString();

            Binding bind_V13_switchCount = new Binding("Text", FormMenu.s_switchCount, "V13D", true, DataSourceUpdateMode.OnPropertyChanged);
            V13_switchTimes.DataBindings.Add(bind_V13_switchCount);
            Binding bind_V14_switchCount = new Binding("Text", FormMenu.s_switchCount, "V14D", true, DataSourceUpdateMode.OnPropertyChanged);
            V14_switchTimes.DataBindings.Add(bind_V14_switchCount);
            Binding bind_V17_switchCount = new Binding("Text", FormMenu.s_switchCount, "V17D", true, DataSourceUpdateMode.OnPropertyChanged);
            V17_switchTimes.DataBindings.Add(bind_V17_switchCount);
        }

        private void switchTimeLimitSet_Click(object sender, EventArgs e)
        {
            ushort x;
            if (UInt16.TryParse(TxtSwitchTimeLimit.Text, out x) && (x < 1000))
            {
                Noi_gao.s_maxSwitchCount = x;
                SwitchCount.Text = Noi_gao.s_maxSwitchCount.ToString();
                DatGioiHan.Invoke(null, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Chỉ được nhập số nguyên dương nhỏ hơn 1000 !", "Warning");
            }
        }

        private void V13_switchTimesReset_Click(object sender, EventArgs e)
        {
            FormMenu.s_switchCount.V13D = 0;
            WarningReset.Invoke(null, EventArgs.Empty);
        }

        private void V14_switchTimesReset_Click(object sender, EventArgs e)
        {
            FormMenu.s_switchCount.V14D = 0;
            WarningReset.Invoke(null, EventArgs.Empty);
        }

        private void V17_switchTimesReset_Click(object sender, EventArgs e)
        {
            FormMenu.s_switchCount.V17D = 0;
            WarningReset.Invoke(null, EventArgs.Empty);
        }
    }
}
