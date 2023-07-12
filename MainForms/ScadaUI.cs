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

        public void Valve_StateChanged(object sender, EventArgs e)
        {
            (sender as StandardControl).DataBindings[0].WriteValue();
            ThayDoi.Invoke(this, EventArgs.Empty);
        }
    }
}
