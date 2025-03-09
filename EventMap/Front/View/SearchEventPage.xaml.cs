using EventMap.Back;
using EventMap.Front.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventMap.Front.View
{
    /// <summary>
    /// Interaction logic for SearchEventPage.xaml
    /// </summary>
    public partial class SearchEventPage : Page
    {
        public ObservableCollection<Dogadjaj> Events { get; set; }
        public ObservableCollection<Dogadjaj> FilteredEvents { get; set; }
        //public ObservableCollection<Dogadjaj> AllEvents { get; set; }

        public SearchEventPage()
        {
            InitializeComponent();
            ShowAllEventsViewModel showAllEventsViewModel = new ShowAllEventsViewModel();
            this.DataContext = showAllEventsViewModel;
            Events = showAllEventsViewModel.Events;
            FilteredEvents = new ObservableCollection<Dogadjaj>(Events);
            EventsList.ItemsSource = FilteredEvents;

            SearchVisitors.Items.Add("less1000");
            SearchVisitors.Items.Add("over1000to5000");
            SearchVisitors.Items.Add("over5000to10000");
            SearchVisitors.Items.Add("over10000");

            SearchType.Items.Add("Muzicki");
            SearchType.Items.Add("Sportski");
            SearchType.Items.Add("Filmski");


        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            AddPage showAllEvents = new AddPage();
            //this.Content = showAllEvents;
            NavigationService.Navigate(showAllEvents);
        }


        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage();
            NavigationService.Navigate(settingsPage);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            TutorialPage tutorialPage = new TutorialPage();
            NavigationService.Navigate(tutorialPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            NavigationService.Navigate(homePage);
        }

        private void ApplyFilterButton(object sender, RoutedEventArgs e)
        {
            string searchMark = SearchOznaka.Text;
            string searchText = SearchName.Text;
            string searchCity = SearchCity.Text;
            string searchCountry = SearchCountry.Text;
            string searchCost = SearchCost.Text;
            DateTime searchDate = SearchDate.SelectedDate ?? DateTime.MinValue;

            string selectedVisitors = SearchVisitors.SelectedItem?.ToString();
            string selectedType = SearchType.SelectedItem?.ToString();


            if (string.IsNullOrWhiteSpace(searchText) &&
                string.IsNullOrWhiteSpace(searchMark) &&
                string.IsNullOrWhiteSpace(selectedType) &&
                string.IsNullOrWhiteSpace(selectedVisitors) &&
                string.IsNullOrWhiteSpace(searchCity) &&
                string.IsNullOrWhiteSpace(searchCountry) &&
                string.IsNullOrWhiteSpace(searchCost)

                )
            {
                // Ako nema teksta za pretragu, prikazujemo sve događaje
                FilteredEvents.Clear();
                foreach (var dogadjaj in Events)
                {
                    FilteredEvents.Add(dogadjaj);
                }
            }
            else
            {
                var filtered = Events.Where(d => 
                (string.IsNullOrWhiteSpace(searchMark) || d.Oznaka.Contains(searchMark,StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(searchText) || d.Naziv.Contains(searchText, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(selectedType) || d.TipOznaka == selectedType) &&
                (string.IsNullOrEmpty(selectedVisitors) || d.Posecenost.ToString() == selectedVisitors) &&
                (string.IsNullOrWhiteSpace(searchCity) || d.Grad.Contains(searchCity, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(searchCountry) || d.Drzava.Contains(searchCountry, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrWhiteSpace(searchCost) || d.ProsecanTrosak.ToString() == searchCost &&
                (searchDate == DateTime.MaxValue || d.DatumOdrzavanja.Date == searchDate.Date))
                ).ToList();



                FilteredEvents.Clear();
                foreach (var dogadjaj in filtered)
                {
                    FilteredEvents.Add(dogadjaj);
                }
            }
        }

        private void ResetFilterButton(object sender, RoutedEventArgs e)
        {
            // Obriši tekst u polju za pretragu
            SearchName.Text = string.Empty;
            SearchOznaka.Text = string.Empty;
            SearchType.Text = string.Empty;
            SearchVisitors.Text = string.Empty;
            SearchCity.Text = string.Empty;
            SearchCountry.Text = string.Empty;
            SearchCost.Text = string.Empty;
            SearchDate.Text = string.Empty;


            // Prikazujemo sve događaje
            FilteredEvents.Clear();
            foreach (var dogadjaj in Events)
            {
                FilteredEvents.Add(dogadjaj);
            }
        }
    }
}
