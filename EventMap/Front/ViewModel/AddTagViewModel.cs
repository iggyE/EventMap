using EventMap.Back;
using EventMap.Front.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Input;

namespace EventMap.Front.ViewModel
{
    public class AddTagViewModel
    {

        public ICommand AddTagCommand { get; set; }

        public string Oznaka { get; set; }
        public string Boja { get; set; }
        public string Opis { get; set; }

        public AddTagViewModel()
        {
            AddTagCommand = new RelayCommand(AddTag, CanAddTag);
        }

        private bool CanAddTag(object obj)
        {
            return true;
        }
        private void AddTag(object obj)
        {
            TagsManager.AddTag(new Etiketa() { Oznaka = Oznaka, Boja = Boja, Opis = Opis });
        }



    }
}
