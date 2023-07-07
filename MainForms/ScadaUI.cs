using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.SubForms;
using SymbolFactoryDotNet;

namespace test.MainForms
{
    public class ScadaUI : Form
    {
        private protected void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private protected void valve_Click(object sender, EventArgs e)
        {
            var currentValve = (StandardControl)sender;
            ValveConfig valve = new ValveConfig(currentValve);
            valve.ShowDialog();
        }
    }
}
