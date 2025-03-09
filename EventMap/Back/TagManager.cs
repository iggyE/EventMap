using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace EventMap.Back
{
    public class TagsManager
    {
        public static ObservableCollection<Etiketa> _DatabaseTags = new ObservableCollection<Etiketa>() { new Etiketa() { Oznaka = "Ulaz", Boja = "#FFA07A", Opis = "Ulaz sa severne strane objekta i sto ranije"},
            new Etiketa() { Oznaka = "Vreme", Boja = "#6495ED", Opis = "Ponesite kisobrane - dogadjaj na otvorenom"},
                                                                                                   new Etiketa() { Oznaka = "Garderoba", Boja = "#8A2BE2", Opis = "Garderoba je dostupna u prizemlju"},
                                                                                                   new Etiketa() { Oznaka = "Izgubljeno", Boja = "#FFD700", Opis = "Stvari koje izgubite prijavite na ulazu, a ako nadjete donesite!"}};


        public static ObservableCollection<Etiketa> GetTags() { return _DatabaseTags; }

        public static void AddTag(Etiketa tag)
        {
            _DatabaseTags.Add(tag);

        }



    }
}
