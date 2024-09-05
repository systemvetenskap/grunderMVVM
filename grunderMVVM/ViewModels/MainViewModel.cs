using grunderMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using System.Windows.Input;
using grunderMVVM.Commands;
//ny testkommentar done
namespace grunderMVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        // Måste binda mot en property!
        public ICanFly SelectedFlyingObject { get; set; }
        public ICommand AddObjectCommand { get;}

        private List<ICanFly> _prospects = new List<ICanFly>();
        // backing fields
        //private ICanFly _selectedFlyingObject;


        //public ICanFly SelectedFlyingObject
        //{
        //    get { return _selectedFlyingObject; }
        //    set 
        //    {
        //        if (_selectedFlyingObject != value)
        //        {
        //            _selectedFlyingObject = value; 
        //            OnPropertyChanged(nameof(SelectedFlyingObject));
        //            CheckObject(_selectedFlyingObject);
        //        }    

        //    }
        //}


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
        private void AddObject()
        {
            var prospect = _prospects.FirstOrDefault();
            if (prospect != null)
            {
                FlyingObjects.Add(prospect);
                _prospects.Remove(prospect);
            }
        }
        public ObservableCollection<ICanFly> FlyingObjects { get; set; } = new ObservableCollection<ICanFly>();
        public MainViewModel()
        {
            var bird = new Bird();
            var airplane = new Airplane();
            FlyingObjects.Add(bird);
            FlyingObjects.Add(airplane);
            var prospect = new Bird();
            _prospects.Add(prospect);
            AddObjectCommand = new RelayCommand(AddObject);
        }
    }
}
