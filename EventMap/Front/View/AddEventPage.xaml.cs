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
    /// Interaction logic for AddEventPage.xaml
    /// </summary>
    public partial class AddEventPage : Page
    {
        public ObservableCollection<TipDogadjaja> AllTypes { get; set; }

        public AddEventPage()
        {
            InitializeComponent();
            AddEventViewModel addEventViewModel = new AddEventViewModel();
            this.DataContext = addEventViewModel;
            ShowTypeViewModel showTypeViewModel = new ShowTypeViewModel();
            ShowTagsViewModel showTagsViewModel = new ShowTagsViewModel();
            TypeManager typesManager = new TypeManager();
            AllTypes = showTypeViewModel.Types;

            ComboBoxTipDogadjaja.ItemsSource = AllTypes;
            ComboBoxTipDogadjaja.DisplayMemberPath = "TipOznaka";

            ComboBoxPosecenost.Items.Add("less1000");
            ComboBoxPosecenost.Items.Add("over1000to5000");
            ComboBoxPosecenost.Items.Add("over5000to10000");
            ComboBoxPosecenost.Items.Add("over10000");


        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            AddPage addPage = new AddPage();
            NavigationService.Navigate(addPage);
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
            TutorialPage tutorialPage = new TutorialPage();
            NavigationService.GoBack();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            NavigationService.Navigate(homePage);
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            AddPage showAllEvents = new AddPage();
            NavigationService.Navigate(showAllEvents);
        }

        private void AddEventButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully added event!");
            NavigationService.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            NavigationService.Navigate(homePage);
        }
    }
}
