using EventMap.Back;
using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using EventMap.Front.ViewModel;
using System.Collections.ObjectModel;


namespace EventMap.Front.View
{
    /// <summary>
    /// Interaction logic for DetailPage.xaml
    /// </summary>
    public partial class DetailPage : Page
    {
        public DetailPage(Dogadjaj selectedEvent)
        {
            InitializeComponent();
            DataContext = selectedEvent;

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

        private void UploadButton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == true)
            {
                string selectedImagePath = openFileDialog.FileName;
                string destinationFolderPath = @"C:\Users\iwanmf\Desktop\upload";

                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                string destinationFilePath = System.IO.Path.Combine(destinationFolderPath, System.IO.Path.GetFileName(selectedImagePath));
                File.Copy(selectedImagePath, destinationFilePath, true);

              //  IconTextBox.Text = destinationFilePath;

                IconImage.Source = new BitmapImage(new Uri(destinationFilePath));

                MessageBox.Show("Slika uspesno dodata!");
            }
        }
    }
}
