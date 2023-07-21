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
using test.Database;

namespace test.SubForms
{
    public partial class ValveConfig : Form, INotifyPropertyChanged
    {
        protected override void OnLoad(EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            base.OnLoad(e);
        }

        private string _state;
        public string State 
        { 
            get => this._state;
            set
            {
                if (this._state == value) return;
                this._state = value;
                NotifyPropertyChanged("State");
            }
        }
        public StandardControl CurrentValve { get; set; }

        
        public event EventHandler StateChanged;
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ValveConfig(StandardControl currentValve)
        {
            InitializeComponent();
            CurrentValve = currentValve;

            onButton.Visible = !(FormMenu.s_autmanState);
            offButton.Visible = !(FormMenu.s_autmanState);

            updateState(CurrentValve.DiscreteValue1);

        }

        private void updateState(bool state)
        {
            State = state ? "ON" : "OFF";
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            CurrentValve.DiscreteValue1 = true & FormMenu.s_powerState;
            updateState(CurrentValve.DiscreteValue1);
            StateChanged.Invoke(this.CurrentValve, EventArgs.Empty);
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            CurrentValve.DiscreteValue1 = false;
            updateState(CurrentValve.DiscreteValue1);
            StateChanged.Invoke(this.CurrentValve, EventArgs.Empty);
        }


        private void ValveConfig_Load(object sender, EventArgs e)
        {
            Binding valveNameBinding = new Binding("Text", CurrentValve, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            valveName.DataBindings.Add(valveNameBinding);
            Binding valveStateBinding = new Binding("Text", this, "State", false, DataSourceUpdateMode.OnPropertyChanged);
            valveState.DataBindings.Add(valveStateBinding);
        }
    }
}
