using System.Windows.Media.Converters;

namespace grunderMVVM.Models
{
    public class Airplane : ICanFly
    {
        public int Altitude { get; }
        public int NumberOfPassengers { get; set; }
        public int NumberOfFirstClassPassengers { get; set; }
        public int FreightWeight { get; set; }
        public string Id { get; set; }
        public string TypeName => "Flygplan";

        public double Speed => 1;
        public double Fuel => 1;
        public void Fly()
        {

        }
        private List<string> names = new List<string>();    
    }
}
