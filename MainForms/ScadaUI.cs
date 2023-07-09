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
        public event PropertyChangedEventHandler PropertyChanged;

        private protected void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private protected void valve_Click(object sender, EventArgs e)
        {
            var currentValve = (StandardControl)sender;
            ValveConfig valveCfg = new ValveConfig(currentValve);
            valveCfg.StateChanged += Valve_StateChanged;
            valveCfg.ShowDialog();
        }

        public void Valve_StateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("In HMI: " + (sender as StandardControl).DiscreteValue1.ToString());
            ThayDoi.Invoke(this, EventArgs.Empty);
        }
    }
}
