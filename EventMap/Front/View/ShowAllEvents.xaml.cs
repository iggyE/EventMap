using EventMap.Back;
using EventMap.Front.ViewModel;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventMap.Front.View
{
    /// <summary>
    /// Interaction logic for ShowAllEvents.xaml
    /// </summary>
    public partial class ShowAllEvents : Page
    {
        public ObservableCollection<Dogadjaj> Events { get; set; }
        public ShowAllEvents()
        {
            InitializeComponent();
            ShowAllEventsViewModel showAllEventsViewModel = new ShowAllEventsViewModel();
            this.DataContext = showAllEventsViewModel;
            Events = showAllEventsViewModel.Events;
            //Events = new ObservableCollection<Dogadjaj>
            //{
            //    new Dogadjaj() { Oznaka = "Exit", Ikona = "C:\\Users\\iwanmf\\Desktop\\EventMap\\EventMap\\Front\\Images\\exitt.jpg", Naziv = "Exit", TipDogadjaja = "Muzicki", Opis = "Exit je festival muzike koji se odrzava svake godine u Novom Sadu na Petrovaradinskoj tvrdjavi. Dolaze poznati pevaci iz celog sveta.", Posecenost = "10000+", Humanitarni = false, ProsecanTrosak = 5500, X = 50,Y = 50, Drzava = "Srbija", Grad = "Novi Sad", DatumOdrzavanja = new DateTime(2024, 8, 30), IstorijaDatuma = new List<DateTime> { new DateTime(2023, 8, 30), new DateTime(2022, 8, 30) } }, new Dogadjaj() { Oznaka = "gu", Ikona="C:\\Users\\iwanmf\\Desktop\\EventMapIzmena\\EventMap\\Front\\Images\\rostilj.jpg", Naziv = "Guca", TipDogadjaja = "Muzicki", Opis = "Festival trubaca", Posecenost = "", Humanitarni = false, ProsecanTrosak = 6000, X = 150,Y=200, Drzava = "Srbija", Grad = "Guca", DatumOdrzavanja = new DateTime(2024, 6, 16) }, new Dogadjaj() { Oznaka = "gsa", Ikona="C:\\Users\\iwanmf\\Desktop\\EventMapIzmena\\EventMap\\Front\\Images\\rostilj.jpg", Naziv = "AGASGG", TipDogadjaja = "Filmski", Opis = "gdsgsd", Posecenost = "2530", Humanitarni = false, ProsecanTrosak = 200,X=200,Y=250, Drzava = "gdsgsd", Grad = "gdagasg", DatumOdrzavanja = new DateTime(2024, 7, 23) }, new Dogadjaj() { Oznaka = "pal", Ikona="C:\\Users\\iwanmf\\Desktop\\EventMapIzmena\\EventMap\\Front\\Images\\rostilj.jpg", Naziv = "Palic Film Fest", TipDogadjaja = "Filmski", Opis = "Palicki filmski fest", Posecenost = "4000", Humanitarni = false, ProsecanTrosak = 400, X=250,Y=300, Drzava = "Srbija", Grad = "Subotica", DatumOdrzavanja = new DateTime(2024, 8, 6) }, new Dogadjaj() { Oznaka = "Oly", Ikona = "C:\\Users\\iwanmf\\Desktop\\EventMapIzmena\\EventMap\\Front\\Images\\rostilj.jpg", Naziv = "Olimp fest", TipDogadjaja = "Filmski", Opis = "filmski fest na olimpu", Posecenost = "2000", Humanitarni = true, ProsecanTrosak = 200, X=350,Y=400, Drzava = "Grcka", Grad = "Olimp", DatumOdrzavanja = new DateTime(2024, 6, 12) }

            //};
        this.DataContext = this;
        }

    private void Button_Click1(object sender, RoutedEventArgs e)
        {
            AddEventPage addPage = new AddEventPage();
            NavigationService.Navigate(addPage);
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            EventsList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {

            var dogadjaj = (Dogadjaj)obj;

            return dogadjaj.Oznaka.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase) || dogadjaj.ProsecanTrosak.ToString().Contains(FilterTextBox.Text) || dogadjaj.Posecenost.ToString().Contains(FilterTextBox.Text) || dogadjaj.TipOznaka.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase) || dogadjaj.Naziv.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase)  || dogadjaj.Grad.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase) || dogadjaj.Drzava.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TutorialPage tutorialPage = new TutorialPage();
            NavigationService.GoBack();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            NavigationService.Navigate(homePage);
        }

        private void myListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EventsList.SelectedItem != null)
            {
                DetailsButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            AddPage addPage = new AddPage();
            NavigationService.Navigate(addPage);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();
            NavigationService.Navigate(settingsPage);
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            TutorialPage tutorialPage = new TutorialPage();
            NavigationService.Navigate(tutorialPage);
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if (EventsList.SelectedItem != null)
            {
                Dogadjaj selectedEvent = EventsList.SelectedItem as Dogadjaj;
                NavigationService.Navigate(new DetailPage(selectedEvent));
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (EventsList.SelectedItem != null)
            {
                Dogadjaj selectedEvent = EventsList.SelectedItem as Dogadjaj;
                Events.Remove(selectedEvent);
                MessageBox.Show("Succesfully removed event!");
             
            }
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (EventsList.SelectedItem != null)
            {
                Dogadjaj selectedEvent = EventsList.SelectedItem as Dogadjaj;
                EditEventPage editEventPage = new EditEventPage(selectedEvent);
                NavigationService.Navigate(new EditEventPage(selectedEvent));
            }
        }


    //public void RefreshEvents()
    //{
    //    EventsList.Items.Refresh(); 
    //}

    private void SearchPageButton(object sender, RoutedEventArgs e)
        {
            SearchEventPage filterEvent = new SearchEventPage();
            NavigationService.Navigate(filterEvent);
        }
    }
}
