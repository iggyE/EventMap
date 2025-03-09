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

namespace EventMap.Front.View
{
    /// <summary>
    /// Interaction logic for LocationPage.xaml
    /// </summary>
    public partial class LocationPage : Page
    {
        public ObservableCollection<Lokacija> Locations { get; set; }

        public LocationPage()
        {
            InitializeComponent();
            ShowLocationViewModel showLocationViewModel = new ShowLocationViewModel(); 
            this.DataContext = showLocationViewModel;
            Locations = showLocationViewModel.Locations;
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

        private void OpenAddLocation(object sender, RoutedEventArgs e)
        {
            LocationAddPage locationAddPage = new LocationAddPage();
            NavigationService.Navigate(locationAddPage);
        }

        private void ChangeButton(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            if (LocationList.SelectedItem != null)
            {
                Lokacija selectedlocation = LocationList.SelectedItem as Lokacija;
                Locations.Remove(selectedlocation);
                MessageBox.Show("Succesfully removed location!");
            }
        }
    }
}
