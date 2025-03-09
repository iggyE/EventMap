using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
   
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

        private void OpenEventsButton(object sender, RoutedEventArgs e)
        {
            ShowAllEvents openEvents = new ShowAllEvents();
            NavigationService.Navigate(openEvents);
        }

        private void OpenLocationButton(object sender, RoutedEventArgs e)
        {
            LocationPage locationPage = new LocationPage();
            NavigationService.Navigate(locationPage);
        }

        private void OpenTicketButton(object sender, RoutedEventArgs e)
        {
            TagPage tagPage = new TagPage();
            NavigationService.Navigate(tagPage);
        }
    }
}