using System.Collections.ObjectModel;
using System.IO; // FILE TOIMINNOT
using System.Text.Json;

namespace SerialisoivaUpeeWPFAppi
{
    internal static class Tallentaja
    {
        private static string tiedostonimi = "autolista.json";
        public static bool Tallenna(ObservableCollection<Auto> autolista)
        {
            try { 
                var json_muoto = JsonSerializer.Serialize(autolista);
                File.WriteAllText(tiedostonimi, json_muoto);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static ObservableCollection<Auto> LueAutot()
        {
            try { 
                var json_muoto = File.ReadAllText(tiedostonimi);
                var autolista = JsonSerializer.Deserialize<ObservableCollection<Auto>>(json_muoto);
                if (autolista == null) 
                    return new ObservableCollection<Auto>();
                return autolista;
            }
            catch
            {
                return new ObservableCollection<Auto>();
            }

        }
    }
}
