using EventMap.Back;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventMap.Front.View
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : System.Windows.Controls.Page
    {
        public HomePage()
        {
            InitializeComponent();
            Events = new ObservableCollection<Dogadjaj>
            {
            new Dogadjaj() { Oznaka = "Exit", Ikona = "\\Front\\Images\\exit.jpeg", Naziv = "Exit", TipOznaka = "Muzicki", Opis = "Exit je festival muzike koji se odrzava svake godine u Novom Sadu na Petrovaradinskoj tvrdjavi. Dolaze poznati pevaci iz celog sveta.", Posecenost = Posecenost.over10000, Humanitarni = false, ProsecanTrosak = 5500, X = 50,Y = 50, Drzava = "Srbija", Grad = "Novi Sad", DatumOdrzavanja = new DateTime(2024, 8, 30), IstorijaDatuma = new List<DateTime> { new DateTime(2023, 8, 30), new DateTime(2022, 8, 30) } }, new Dogadjaj() { Oznaka = "FIFA", Ikona= "\\Front\\Images\\fifa.jpg", Naziv = "Svetsko prvenstvo 2010", TipOznaka = "Sportski", Opis = "Svetsko prvenstvo koje se odrzalo 2010 godine u Juznoj Africi. Jedno od najboljih svetskih prvestva, pobednik je bila Spanija.", Posecenost = Posecenost.over10000, Humanitarni = false, ProsecanTrosak = 6000, X = 150,Y=200, Drzava = "South Africa", Grad = "Pretoria", DatumOdrzavanja = new DateTime(2010, 6, 16) }, new Dogadjaj() { Oznaka = "film", Ikona= "\\Front\\Images\\filmski.jpg", Naziv = "Chicago films", TipOznaka = "Filmski", Opis = "Svake godine u Chigaco,USA se odrzava veliki filmski festival, koji traje 10 dana! Dolaze turisti iz cele istocne Amerike", Posecenost = Posecenost.over1000to5000, Humanitarni = true, ProsecanTrosak = 1200,X=200,Y=250, Drzava = "Chicago,United States", Grad = "Illionis", DatumOdrzavanja = new DateTime(2024, 7, 23), IstorijaDatuma = new List<DateTime> { new DateTime(2023, 7, 23), new DateTime(2022, 7, 23), new DateTime(2021,7,23) }  }, new Dogadjaj() { Oznaka = "Oct Fst", Ikona="", Naziv = "Octobar Fest", TipOznaka = "Muzicki", Opis = "Najveci pivski festival na svetu koji se odrzava u Nemackoj je pravo iskustvo za sve alkoholicare.", Posecenost = Posecenost.over1000to5000, Humanitarni = false, ProsecanTrosak = 900, X=250,Y=300, Drzava = "Nemacka", Grad = "Minhen", DatumOdrzavanja = new DateTime(2024, 8, 6) }, new Dogadjaj() { Oznaka = "Aus", Ikona = "\\Front\\Images\\tenis.jpg", Naziv = "Australia open", TipOznaka = "Sportski", Opis = "Grand slam teniski turnir (najveceg prestiza) koji se odrzava januara i februara svake godine!", Posecenost = Posecenost.over10000, Humanitarni = false, ProsecanTrosak = 2350, X=350,Y=400, Drzava = "Australia", Grad = "Melbourne", DatumOdrzavanja = new DateTime(2024, 1, 23), IstorijaDatuma = new List<DateTime> { new DateTime(2023, 1, 23), new DateTime(2022, 1, 23), new DateTime(2021, 1, 23) } } 

        };
            this.DataContext = this;
            PopulateCanvas();
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
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        /////na dole je sve za Drag and drop i gore u construtork

        public ObservableCollection<Dogadjaj> Events { get; set; }
        public Dogadjaj selectedEvent;
        private bool isDragging = false;
        private Point startPosition;
        private Image draggedImage;

        private void PopulateCanvas()
        {
            foreach (var myEvent in Events)
            {
                Image img = new Image
                {
                    Source = new BitmapImage(new Uri(myEvent.Ikona, UriKind.RelativeOrAbsolute)),
                    Width = 50,
                    Height = 50,
                    Tag = myEvent,
                    IsManipulationEnabled = true
                };
                img.MouseLeftButtonDown += Icon_MouseLeftButtonDown;
                img.MouseLeftButtonUp += Icon_MouseLeftButtonUp;
                Canvas.SetLeft(img, 100); // Prilagodite po potrebi
                Canvas.SetTop(img, 100);  // Prilagodite po potrebi
                canvas.Children.Add(img);
            }
        }

        private void Icon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Image img)
            {
                isDragging = true;
                startPosition = e.GetPosition(canvas);
                draggedImage = img;
                img.CaptureMouse();
            }
        }


        private void Icon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
                if (draggedImage != null)
                {
                    draggedImage.ReleaseMouseCapture();
                    draggedImage = null;
                }
            }
            else
            {
                // Ako nije u procesu drag-and-drop, otvori DetailPage
                if (sender is Image img && img.Tag is Dogadjaj myEvent)
                {
                    MessageBox.Show("Icon clicked!");
                    DetailPage detailPage = new DetailPage(myEvent);
                    NavigationService.Navigate(detailPage);
                }
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggedImage != null)
            {
                Point currentPosition = e.GetPosition(canvas);
                double deltaX = currentPosition.X - startPosition.X;
                double deltaY = currentPosition.Y - startPosition.Y;
                Canvas.SetLeft(draggedImage, Canvas.GetLeft(draggedImage) + deltaX);
                Canvas.SetTop(draggedImage, Canvas.GetTop(draggedImage) + deltaY);
                startPosition = currentPosition;
            }
        }

        private void Canvas_Drop(object sender, DragEventArgs e)
        {
            // Ovdje možete implementirati logiku za ispuštanje ako je potrebno
            MessageBox.Show("Sucessfully dropped there!");
        }
    }
}
