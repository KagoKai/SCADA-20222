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
        private bool _V13;
        private bool _V14;
        private bool _V17;
        public bool V13 
        { 
            get => this._V13; 
            set
            {
                if (this._V13 == value) return;
                this._V13 = value;
                NotifyPropertyChanged("V13");
            }
        }
        public bool V14 
        {
            get => this._V14;
            set
            {
                if (this._V14 == value) return;
                this._V14 = value;
                NotifyPropertyChanged("V14");
            }
        }
        public bool V17 
        {
            get => this._V17;
            set
            {
                if (this._V17 == value) return;
                this._V17 = value;
                NotifyPropertyChanged("V17");
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
