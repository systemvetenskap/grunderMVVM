using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grunderMVVM.Models
{
    public class Bird : ICanFly
    {
        public int Altitude { get; }

        public string TypeName => "Fågel";

        public double Speed { get; private set; }

        public Bird()
        {
            Speed = 4.5;
        }
        public void Fly()
        {
           // flyg på
        }
    }
}
