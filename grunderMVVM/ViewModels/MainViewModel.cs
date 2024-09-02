using grunderMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grunderMVVM.ViewModels
{
    public class MainViewModel
    {
        public List<ICanFly> FlyingObjects { get; set; } = new List<ICanFly>();
        public MainViewModel()
        {
            var bird = new Bird();
            var airplane = new Airplane();
            FlyingObjects.Add(bird);
            FlyingObjects.Add(airplane);
        }
    }
}
