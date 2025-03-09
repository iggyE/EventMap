using EventMap.Back;
using EventMap.Front.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace EventMap.Front.ViewModel
{
    public class AddEventViewModel
    {
        public ICommand AddEventCommand { get; set; }

        public string Oznaka { get; set; }
        public string Ikona {  get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public TipDogadjaja TipDogadjaja { get; set; }
        public string TipOznaka { get; set; }

        public Posecenost Posecenost { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }

        public bool Humanitarni { get; set; }
        public decimal ProsecanTrosak { get; set; }

        public DateTime DatumOdrzavanja { get; set; }
        public List<DateTime> IstorijaDatuma { get; set; }


     //   public static ObservableCollection<Dogadjaj> _DatabaseEvents = new ObservableCollection<Dogadjaj>() { new Dogadjaj() { Oznaka = "rostilj",  Naziv = "rostiljijara", TipDogadjaja = "Muzicki", Opis = "Festival hrane i muzike", Posecenost = 150000, Humanitarni = false, ProsecanTrosak = 5500, Drzava = "Srbija", Grad = "Leskovac", DatumOdrzavanja = new DateTime(2024, 8, 30) }, new Dogadjaj() { Oznaka = "gu", Naziv = "Guca", TipDogadjaja = "Muzicki", Opis = "Festival trubaca", Posecenost = 90000, Humanitarni = false, ProsecanTrosak = 6000, Drzava = "Srbija", Grad = "Guca", DatumOdrzavanja = new DateTime(2024, 6, 16) }, new Dogadjaj() { Oznaka = "gsa", Naziv = "AGASGG", TipDogadjaja = "Muzicki", Opis = "gdsgsd", Posecenost = 2530, Humanitarni = false, ProsecanTrosak = 200, Drzava = "gdsgsd", Grad = "gdagasg", DatumOdrzavanja = new DateTime(2024, 7, 23) }, new Dogadjaj() { Oznaka = "pal", Naziv = "Palic Film Fest", TipDogadjaja = "Filmski", Opis = "Palicki filmski fest", Posecenost = 4000, Humanitarni = false, ProsecanTrosak = 400, Drzava = "Srbija", Grad = "Subotica", DatumOdrzavanja = new DateTime(2024, 8, 6) }, new Dogadjaj() { Oznaka = "Oly", Naziv = "Olimp fest", TipDogadjaja = "Filmski", Opis = "filmski fest na olimpu", Posecenost = 2000, Humanitarni = true, ProsecanTrosak = 200, Drzava = "Grcka", Grad = "Olimp", DatumOdrzavanja = new DateTime(2024, 6, 12) } };

     //   public static ObservableCollection<Dogadjaj> GetEvents() { return _DatabaseEvents; }
     //   public static void AddEvent(Dogadjaj dogadjaj)
     //   {
      //      _DatabaseEvents.Add(dogadjaj);

     //   }

        public AddEventViewModel()
        {
            AddEventCommand = new RelayCommand(AddEvent, CanAddEvent);
        }

        private bool CanAddEvent(object obj)
        {
            return true;
        }

        private void AddEvent(object obj)
        {
            EventsManager.AddEvent(
                new Dogadjaj() { Oznaka = Oznaka, Ikona = "", Naziv = Naziv, Opis = Opis, TipDogadjaja = TipDogadjaja ,TipOznaka = TipOznaka, Posecenost = Posecenost, Grad = Grad , Drzava = Drzava , Humanitarni = Humanitarni, ProsecanTrosak = ProsecanTrosak ,  DatumOdrzavanja = DatumOdrzavanja});
        }
    }
}
