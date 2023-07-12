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
using test.Database;
using SymbolFactoryDotNet;
using test.SubForms;

namespace test
{
    public partial class Noi_gao : ScadaUI
    {
        public PLCComm CurrentComm { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }

        public Noi_gao(PLCComm currentComm)
        {
            InitializeComponent();
            CurrentComm = currentComm;
            this.returnButton.Click += base.returnButton_Click;
            this.V13.Click += valve_Click;
            this.V14.Click += valve_Click;
            this.V17.Click += valve_Click;

            Binding bind_V13_State = new Binding("DiscreteValue1", this.CurrentComm, "V13", false, DataSourceUpdateMode.OnPropertyChanged);
            this.V13.DataBindings.Add(bind_V13_State);

            Binding bind_V14_State = new Binding("DiscreteValue1", this.CurrentComm, "V14", false, DataSourceUpdateMode.OnPropertyChanged);
            this.V14.DataBindings.Add(bind_V14_State);

            Binding bind_V17_State = new Binding("DiscreteValue1", this.CurrentComm, "V17", false, DataSourceUpdateMode.OnPropertyChanged);
            this.V17.DataBindings.Add(bind_V17_State);
        }

        private protected void valve_Click(object sender, EventArgs e)
        {
            ValveConfig valveCfg = new ValveConfig((StandardControl)sender);
            valveCfg.StateChanged += Valve_StateChanged;
            valveCfg.ShowDialog();
        }

    }
}
