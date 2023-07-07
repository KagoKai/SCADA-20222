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
        public event PropertyChangedEventHandler PropertyChanged;
        private StandardControl _currentValve;
        private string _state;
        public StandardControl CurrentValve 
        {
            get => _currentValve;
            set => _currentValve = value;
        }
        public string State
        {
            get => _state;
            set
            {
                if (this._state == value) return;
                this._state = value;
                NotifyPropertyChanged("State");
            }
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
            State = (!(CurrentValve.DiscreteValue1) & CurrentValve.DiscreteValue2) ? "ON" : "OFF";

            Binding valveNameBinding = new Binding("Text", CurrentValve, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding valveStateBinding = new Binding("Text", this, "State", false, DataSourceUpdateMode.OnPropertyChanged);
            valveName.DataBindings.Add(valveNameBinding);
            valveState.DataBindings.Add(valveStateBinding);
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            CurrentValve.DiscreteValue1 = false;
            CurrentValve.DiscreteValue2 = true;
            State = "ON";
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            CurrentValve.DiscreteValue1 = true;
            CurrentValve.DiscreteValue2 = false;
            State = "OFF";
        }
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
