using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grunderMVVM.Models
{
    public class Bird : ICanFly
    {
        public int Altitude { get;  }

        public string TypeName => "Fågel";

        public void Fly()
        {
           // flyg på
        }
    }
}
