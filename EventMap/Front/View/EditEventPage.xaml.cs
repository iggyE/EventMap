using EventMap.Back;
using EventMap.Front.ViewModel;
using Microsoft.VisualBasic;
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
    /// Interaction logic for EditEventPage.xaml
    /// </summary>
    public partial class EditEventPage : Page
    {
        private Dogadjaj _originalEvent;
        private Dogadjaj _editableEvent;
        private ShowAllEvents _showAllEventsPage;
        ShowAllEvents showAllEventsPage;


        public EditEventPage()
        {
            InitializeComponent();
            //_originalEvent = selectedEvent;
            //_editableEvent = new Dogadjaj
            //{
            //    // Inicijalizacija _editableEvent
            //};
            //this.DataContext = _editableEvent;
        }
        public ObservableCollection<TipDogadjaja> AllTypes { get; set; }

        public EditEventPage(Dogadjaj selectedEvent)
        {
            InitializeComponent();
            ShowTypeViewModel showTypeViewModel = new ShowTypeViewModel();
            AllTypes = showTypeViewModel.Types;

            ComboTip.ItemsSource = AllTypes;
            ComboTip.DisplayMemberPath = "TipOznaka";

            ComboPosecenost.Items.Add("less1000");
            ComboPosecenost.Items.Add("over1000to5000");
            ComboPosecenost.Items.Add("over5000to10000");
            ComboPosecenost.Items.Add("over10000");

            _originalEvent = selectedEvent;
            _editableEvent = new Dogadjaj
            {
                // Inicijalizacija _editableEvent
                Oznaka = selectedEvent.Oznaka,
                Naziv = selectedEvent.Naziv,
                Opis = selectedEvent.Opis,
                TipDogadjaja = selectedEvent.TipDogadjaja,
                Posecenost = selectedEvent.Posecenost,
                Grad = selectedEvent.Grad,
                Drzava = selectedEvent.Drzava,
                Humanitarni = selectedEvent.Humanitarni,
                ProsecanTrosak = selectedEvent.ProsecanTrosak,
                DatumOdrzavanja = selectedEvent.DatumOdrzavanja,
            };
            this.DataContext = _editableEvent;
            _showAllEventsPage = showAllEventsPage; // Postavljanje reference na ShowAllEventsPage
        }
        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            _originalEvent.Oznaka = _editableEvent.Oznaka;
            _originalEvent.Naziv = _editableEvent.Naziv;
            _originalEvent.Opis = _editableEvent.Opis;
            _originalEvent.TipDogadjaja = _editableEvent.TipDogadjaja;
            _originalEvent.Posecenost = _editableEvent.Posecenost;
            _originalEvent.Grad = _editableEvent.Grad;
            _originalEvent.Drzava = _editableEvent.Drzava;
            _originalEvent.Humanitarni = _editableEvent.Humanitarni;
            _originalEvent.ProsecanTrosak = _editableEvent.ProsecanTrosak;
            _originalEvent.DatumOdrzavanja = _editableEvent.DatumOdrzavanja;

            // Kopirajte ostale izmene nazad u originalni objekat

            //_showAllEventsPage.RefreshEvents(); // Osvežavanje događaja na ShowAllEventsPage
            MessageBox.Show("Succesfully changed event!");
            NavigationService.GoBack();
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
