using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMap.Back
{
    public class TypeManager
    {

        public static ObservableCollection<TipDogadjaja> _DatabaseTypes = new ObservableCollection<TipDogadjaja>() { new TipDogadjaja() { TipOznaka = "Muzicki", TipNaziv = "Muzicki festival", TipIkona = "", TipOpis = "Festival muzike, pevaci, koncreti, uzivanje..." },
                                                                                                               new TipDogadjaja() { TipOznaka = "Sportski", TipNaziv = "Filmski festival", TipIkona = "", TipOpis = "Sportski festival, uglavnom fudbala uz puno zabave!" },
                                                                                                               new TipDogadjaja() { TipOznaka = "Filmski", TipNaziv = "Gastro festival", TipIkona = "", TipOpis = "Festival koji filmove, sve zanrove."}, };


        public static ObservableCollection<TipDogadjaja> GetTypes() { return _DatabaseTypes; }

        public static void AddType(TipDogadjaja tip)
        {
            _DatabaseTypes.Add(tip);

        }

        public static void DeleteType(TipDogadjaja tip)
        {
            _DatabaseTypes.Remove(tip);
        }

    }
}
