using System.Windows.Media.Converters;

namespace grunderMVVM.Models
{
    public class Airplane : ICanFly
    {
        public int Altitude { get; }
        public int NumberOfPassengers { get; set; }
        public string TypeName => "Flygplan";

        public void Fly()
        {

        }
    }
}
