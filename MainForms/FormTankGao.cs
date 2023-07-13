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
            returnButton.Click += base.returnButton_Click;
            V13.Click += valve_Click;
            V14.Click += valve_Click;
            V17.Click += valve_Click;

            Binding bind_V13_State = new Binding("DiscreteValue1", this.CurrentComm, "V13", false, DataSourceUpdateMode.OnPropertyChanged);
            V13.DataBindings.Add(bind_V13_State);

            Binding bind_V14_State = new Binding("DiscreteValue1", this.CurrentComm, "V14", false, DataSourceUpdateMode.OnPropertyChanged);
            V14.DataBindings.Add(bind_V14_State);

            Binding bind_V17_State = new Binding("DiscreteValue1", this.CurrentComm, "V17", false, DataSourceUpdateMode.OnPropertyChanged);
            V17.DataBindings.Add(bind_V17_State);
        }

        private void Noi_gao_Load(object sender, EventArgs e)
        {
            Power_Light.DiscreteValue1 = _powerState;
            AutMan_Light.DiscreteValue1 = _autmanState;
        }
    }
}
