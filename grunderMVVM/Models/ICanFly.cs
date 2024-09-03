using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grunderMVVM.Models
{
    public interface ICanFly
    {
        int Altitude { get;  }
        double Speed { get; }
        /// <summary>
        /// Egenskap som avgör typ
        /// </summary>
        string TypeName { get; }
        void Fly();
    }
}
