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
    /// Interaction logic for TagPage.xaml
    /// </summary>
    public partial class TagPage : Page
    {
        public ObservableCollection<Etiketa> Tags { get; set; }

        public TagPage()
        {
            InitializeComponent();
            ShowTagsViewModel showTagViewModel = new ShowTagsViewModel();
            this.DataContext = showTagViewModel;
            Tags = showTagViewModel.Tags;


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

        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            if(TagList.SelectedItem != null)
            {
                Etiketa selectedTag = TagList.SelectedItem as Etiketa;
                Tags.Remove(selectedTag);
                MessageBox.Show("Succesfully removed tag!");
            }
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Succesfully added tag!");
        }

        private void ChangeButton(object sender, RoutedEventArgs e)
        {

        }

        private void OpenAddTag(object sender, RoutedEventArgs e)
        {
            AddTagPage addTagPage = new AddTagPage();
            NavigationService.Navigate(addTagPage);
        }
    }
}
