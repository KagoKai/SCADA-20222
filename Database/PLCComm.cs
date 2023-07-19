using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace test.Database
{
    public class PLCComm : INotifyPropertyChanged
    {
        private bool _V13D;
        private bool _V14D;
        private bool _V17D;
        public bool V13D 
        { 
            get => this._V13D; 
            set
            {
                if (this._V13D == value) return;
                this._V13D = value;
                NotifyPropertyChanged("V13D");
            }
        }
        public bool V14D
        {
            get => this._V14D;
            set
            {
                if (this._V14D == value) return;
                this._V14D = value;
                NotifyPropertyChanged("V14D");
            }
        }
        public bool V17D
        {
            get => this._V17D;
            set
            {
                if (this._V17D == value) return;
                this._V17D = value;
                NotifyPropertyChanged("V17D");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
