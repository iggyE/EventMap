using EventMap.Back;
using EventMap.Front.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventMap.Front.ViewModel
{
    public class AddLocationViewModel
    {

        public ICommand AddLocationCommand { get; set; }

        public int Id { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }

        public AddLocationViewModel()
        {
            AddLocationCommand = new RelayCommand(AddLocation, CanAddLocation);
        }

        private bool CanAddLocation(object obj)
        {
            return true;
        }
        private void AddLocation(object obj)
        {
            LocationManager.AddLocations(new Lokacija() { Id = Id, Grad = Grad, Drzava = Drzava });
        }



    }
}
