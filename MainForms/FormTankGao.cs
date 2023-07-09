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
            this.HMI_V13.Click += base.valve_Click;
            this.HMI_V14.Click += base.valve_Click;
            this.HMI_V17.Click += base.valve_Click;

            Binding bind_V13_State = new Binding("DiscreteValue1", this.CurrentComm, "V13", false, DataSourceUpdateMode.OnPropertyChanged);
            this.HMI_V13.DataBindings.Add(bind_V13_State);
        }

    }
}
