using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Database
{
    public class Valve
    {
        private string _name;
        private string _state;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string State
        {
            get => _state;
            set => _state = value;
        }
        public Valve(string name, string state)
        {
            Name = name;
            State = state;
        }
    }
}
