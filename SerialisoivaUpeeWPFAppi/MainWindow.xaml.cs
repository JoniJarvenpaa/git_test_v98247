using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace SerialisoivaUpeeWPFAppi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Auto> autolista = new ObservableCollection<Auto>();
        public MainWindow()
        {
            InitializeComponent();
            autolista = Tallentaja.LueAutot();
            AutoDataGrid.ItemsSource = autolista;
        }

        private void LisaaAuto_Button_Click(object sender, RoutedEventArgs e)
        {
            var merkki = merkki_textbox.Text;
            var malli = malli_textbox.Text;
            var vm_raw = vuosimalli_textbox.Text;
            int vuosimalli = 0;
            int.TryParse(vm_raw, out vuosimalli);
            if (vuosimalli != 0 && !string.IsNullOrEmpty(merkki) && !string.IsNullOrEmpty(malli))
            {
                var uusiAuto = new Auto(merkki, malli, vuosimalli);
                merkki_textbox.Text = string.Empty;
                malli_textbox.Text = string.Empty;
                vuosimalli_textbox.Text = string.Empty;
                IlmoitusTeksti.Content = "Uusi auto lisätty onnistuneesti!";
                IlmoitusTeksti.Background = Brushes.LightGreen;
                autolista.Add(uusiAuto);
                AutoDataGrid.ItemsSource = autolista;
                Tallentaja.Tallenna(autolista);
            }
            else
            {
                IlmoitusTeksti.Content = "Virhe auton lisäämisessä! Tarkista kentät.";
                IlmoitusTeksti.Background = Brushes.LightPink;
            }
        }

        private void CheckValues_Click(object sender, RoutedEventArgs e)
        {
            Tallentaja.Tallenna(autolista);
            IlmoitusTeksti.Content = "Muutokset tallennettu!";
            IlmoitusTeksti.Background = Brushes.LightGreen;
        }
    }
}