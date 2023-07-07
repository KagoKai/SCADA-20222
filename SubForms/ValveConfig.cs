using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolFactoryDotNet;

namespace test.SubForms
{
    public partial class ValveConfig : Form
    {
        private StandardControl _currentValve;
        private struct Valve
        {

        }
        public StandardControl CurrentValve 
        {
            get => _currentValve;
            set => _currentValve = value;
        }
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }
        public ValveConfig(StandardControl currentValve)
        {
            InitializeComponent();
            CurrentValve = currentValve;
            this.valveName.Text = CurrentValve.Name;
        }
    }
}
