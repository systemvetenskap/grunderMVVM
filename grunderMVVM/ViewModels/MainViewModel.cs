using grunderMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grunderMVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        // Måste binda mot en property!
        //public ICanFly SelectedFlyingObject { get; set; }
        // backing fields
        private ICanFly _selectedFlyingObject;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ICanFly SelectedFlyingObject
        {
            get { return _selectedFlyingObject; }
            set 
            {
                if (_selectedFlyingObject != value)
                {
                    _selectedFlyingObject = value; 
                    OnPropertyChanged(nameof(SelectedFlyingObject));
                    CheckObject(_selectedFlyingObject);
                }    

            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CheckObject(ICanFly selectedFlyingObject)
        {
           // Kolla objettyp
           if(selectedFlyingObject is Bird)
            {
                var bird = new Bird();
                FlyingObjects.Add(bird);
            }
           else if(selectedFlyingObject is Airplane)
            {
                var plane = new Airplane();
                FlyingObjects.Add(plane);
            }
           // skapa ett nytt 
           // lägg i listan
        }

        public ObservableCollection<ICanFly> FlyingObjects { get; set; } = new ObservableCollection<ICanFly>();
        public MainViewModel()
        {
            var bird = new Bird();
            var airplane = new Airplane();
            FlyingObjects.Add(bird);
            FlyingObjects.Add(airplane);
        }
    }
}
