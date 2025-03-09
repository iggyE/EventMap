using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMap.Back
{
    public class LocationManager
    {
        public static ObservableCollection<Lokacija> _DatabaseLocations = new ObservableCollection<Lokacija>() { new Lokacija() { Id = 1, Grad = "Rim", Drzava = "Italija"},
            new Lokacija() { Id = 2, Grad = "Pariz", Drzava = "Francuska"},
                                                                                                   new Lokacija() { Id = 3, Grad = "Leskovac", Drzava = "Srbija"},
                                                                                                   new Lokacija() { Id = 4, Grad = "Novi Sad", Drzava = "Srbija"}};


        public static ObservableCollection<Lokacija> GetLocations() { return _DatabaseLocations; }

        public static void AddLocations(Lokacija lokacija)
        {
            _DatabaseLocations.Add(lokacija);

        }



    }
}
