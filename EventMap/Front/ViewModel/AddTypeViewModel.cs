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
    public class AddTypeViewModel
    {
        public ICommand AddTypeCommand { get; set; }

        public string Oznaka { get; set; }
        public string Naziv { get; set; }

        public string Ikona { get; set; }
        public string Opis { get; set; }


        public AddTypeViewModel()
        {
            AddTypeCommand = new RelayCommand(AddType, CanAddType);


        }

        private bool CanAddType(object obj)
        {
            return true;
        }

        private void AddType(object obj)
        {
            TypeManager.AddType(new TipDogadjaja() { TipOznaka = Oznaka, TipNaziv = Naziv, TipOpis = Opis, TipIkona = Ikona });
        }




    }
}
