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
        private bool _bomCapCIP;
        private bool _bomSangMalt;
        private bool _bomNuocHoi;
        public bool V13D 
        { 
            get => this._V13D; 
            set
            {
                if (this._V13D == value) return;
                this._V13D = value;
                if (value == false) SwitchCountUp.Invoke("V13D", EventArgs.Empty);
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
                if (value == false) SwitchCountUp.Invoke("V14D", EventArgs.Empty);
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
                if (value == false) SwitchCountUp.Invoke("V17D", EventArgs.Empty);
                NotifyPropertyChanged("V17D");
            }
        }
        public bool BomCapCIP
        {
            get => this._bomCapCIP;
            set
            {
                if (this._bomCapCIP == value) return;
                this._bomCapCIP = value;
                NotifyPropertyChanged("BomCapCIP");
            }
        }
        public bool BomSangMalt
        {
            get => this._bomSangMalt;
            set
            {
                if (this._bomSangMalt == value) return;
                this._bomSangMalt = value;
                NotifyPropertyChanged("BomSangMalt");
            }
        }
        public bool BomNuocHoi
        {
            get => this._bomNuocHoi;
            set
            {
                if (this._bomNuocHoi == value) return;
                this._bomNuocHoi = value;
                NotifyPropertyChanged("BomNuocHoi");
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
        public event EventHandler SwitchCountUp;
    }
}
