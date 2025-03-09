using EventMap.Back;
using EventMap.Front.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventMap.Front.ViewModel
{
    public class ShowLocationViewModel
    {
        public ObservableCollection<Lokacija> Locations { get; set; }



        //public EventType SelectedType { get; set; }
        public ICommand DeleteCommand { get; private set; }

        public ShowLocationViewModel()
        {
            Locations = LocationManager.GetLocations();
            DeleteCommand = new RelayCommand<Lokacija>(DeleteLocation, CanDeleteLocation);

        }

        private bool CanDeleteLocation(Lokacija location)
        {
            return true;
        }

        private void DeleteLocation(Lokacija location)
        {

            Locations.Remove(location);

        }


    }
}
