using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.SubForms;
using SymbolFactoryDotNet;
using System.ComponentModel;

namespace test.MainForms
{
    public class ScadaUI : Form
    {
        public event EventHandler ThayDoi;

        private protected void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private protected void valve_Click(object sender, EventArgs e)
        {
            ValveConfig valveCfg = new ValveConfig((StandardControl)sender);
            valveCfg.StateChanged += Element_StateChanged;
            valveCfg.ShowDialog();
        }

        private protected void pump_Click(object sender, EventArgs e)
        {
            PumpConfig pumpCfg = new PumpConfig((StandardControl)sender);
            pumpCfg.StateChanged += Element_StateChanged;
            pumpCfg.ShowDialog();
        }

        public void Element_StateChanged(object sender, EventArgs e)
        {
            (sender as StandardControl).DataBindings[0].WriteValue();
            ThayDoi.Invoke(this, EventArgs.Empty);
        }

    }
}
