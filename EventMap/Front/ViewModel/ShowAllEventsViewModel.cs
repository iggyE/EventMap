using EventMap.Back;
using EventMap.Front.Commands;
using EventMap.Front.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Navigation;
using EventMap.Front.ViewModel;


namespace EventMap.Front.ViewModel
{
    public class ShowAllEventsViewModel
    {
        public ObservableCollection<Dogadjaj> Events { get; set; }

        public ICommand ShowAllEventsCommand { get; set; }

        //

        public static ObservableCollection<Dogadjaj> _DatabaseEvents = new ObservableCollection<Dogadjaj>() {new Dogadjaj() { Oznaka = "Exit", Ikona = "\\Front\\Images\\exit.jpeg", Naziv = "Exit", TipOznaka = "Muzicki", Opis = "Exit je festival muzike koji se odrzava svake godine u Novom Sadu na Petrovaradinskoj tvrdjavi. Dolaze poznati pevaci iz celog sveta.", Posecenost = Posecenost.over10000, Humanitarni = false, ProsecanTrosak = 5500, X = 50,Y = 50, Drzava = "Srbija", Grad = "Novi Sad", DatumOdrzavanja = new DateTime(2024, 8, 30), IstorijaDatuma = new List<DateTime> { new DateTime(2023, 8, 30), new DateTime(2022, 8, 30) } }, new Dogadjaj() { Oznaka = "FIFA", Ikona= "\\Front\\Images\\fifa.jpg", Naziv = "Svetsko prvenstvo 2010", TipOznaka = "Sportski", Opis = "Svetsko prvenstvo koje se odrzalo 2010 godine u Juznoj Africi. Jedno od najboljih svetskih prvestva, pobednik je bila Spanija.", Posecenost = Posecenost.over10000, Humanitarni = false, ProsecanTrosak = 6000, X = 150,Y=200, Drzava = "South Africa", Grad = "Pretoria", DatumOdrzavanja = new DateTime(2010, 6, 16) }, new Dogadjaj() { Oznaka = "film", Ikona= "\\Front\\Images\\filmski.jpg", Naziv = "Chicago films", TipOznaka = "Filmski", Opis = "Svake godine u Chigaco,USA se odrzava veliki filmski festival, koji traje 10 dana! Dolaze turisti iz cele istocne Amerike", Posecenost = Posecenost.over1000to5000, Humanitarni = true, ProsecanTrosak = 1200,X=200,Y=250, Drzava = "Chicago,United States", Grad = "Illionis", DatumOdrzavanja = new DateTime(2024, 7, 23), IstorijaDatuma = new List<DateTime> { new DateTime(2023, 7, 23), new DateTime(2022, 7, 23), new DateTime(2021,7,23) }  }, new Dogadjaj() { Oznaka = "Oct Fst", Ikona="", Naziv = "Octobar Fest", TipOznaka = "Muzicki", Opis = "Najveci pivski festival na svetu koji se odrzava u Nemackoj je pravo iskustvo za sve alkoholicare.", Posecenost = Posecenost.over1000to5000, Humanitarni = false, ProsecanTrosak = 900, X=250,Y=300, Drzava = "Nemacka", Grad = "Minhen", DatumOdrzavanja = new DateTime(2024, 8, 6) }, new Dogadjaj() { Oznaka = "Aus", Ikona = "\\Front\\Images\\tenis.jpg", Naziv = "Australia open", TipOznaka = "Sportski", Opis = "Grand slam teniski turnir (najveceg prestiza) koji se odrzava januara i februara svake godine!", Posecenost = Posecenost.over10000, Humanitarni = false, ProsecanTrosak = 2350, X=350,Y=400, Drzava = "Australia", Grad = "Melbourne", DatumOdrzavanja = new DateTime(2024, 1, 23), IstorijaDatuma = new List<DateTime> { new DateTime(2023, 1, 23), new DateTime(2022, 1, 23), new DateTime(2021, 1, 23) } } };

        public static ObservableCollection<Dogadjaj> GetEvents() { return _DatabaseEvents; }

        public static void AddEvent(Dogadjaj dogadjaj)
        {
            _DatabaseEvents.Add(dogadjaj);

        }

        //

        public ShowAllEventsViewModel()
        {
            Events = EventsManager.GetEvents();
            ShowAllEventsCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            //AddEventPage addEvent = new AddEventPage();
            //addEvent.Show();
        }



    }
}
