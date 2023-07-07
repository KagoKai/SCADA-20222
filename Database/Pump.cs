using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Database
{
    public class Pump
    {
        private string _name;
        private bool _state;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public bool State
        {
            get => _state;
            set => _state = value;
        }
        public Pump(string name, bool state)
        {
            Name = name;
            State = state;
        }
    }
}
