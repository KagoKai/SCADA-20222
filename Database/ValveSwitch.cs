using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace test.Database
{
    public class ValveSwitch : INotifyPropertyChanged
    {
        UInt16 _V13D_switchCount;
        UInt16 _V14D_switchCount;
        UInt16 _V17D_switchCount;

        public UInt16 V13D_switchCount 
        { 
            get => _V13D_switchCount; 
            set
            {
                if (this._V13D_switchCount == value) return;
                this._V13D_switchCount = value;
                NotifyPropertyChanged("V13D_switchCount");
            }
        }
        public UInt16 V14D_switchCount 
        {
            get => _V14D_switchCount;
            set
            {
                if (this._V14D_switchCount == value) return;
                this._V14D_switchCount = value;
                NotifyPropertyChanged("V14D_switchCount");
            }
        }
        public UInt16 V17D_switchCount 
        {
            get => _V17D_switchCount;
            set
            {
                if (this._V17D_switchCount == value) return;
                this._V17D_switchCount = value;
                NotifyPropertyChanged("V17D_switchCount");
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
