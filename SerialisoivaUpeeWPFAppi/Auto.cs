using CommunityToolkit.Mvvm.ComponentModel;

namespace SerialisoivaUpeeWPFAppi
{
    internal class Auto : ObservableObject
    {

        private string _merkki;
        public string merkki 
        { 
            get 
            { 
                return _merkki; 
            } 
            set
            {
                SetProperty(ref _merkki, value);
            }
        }
        public string malli { get; set; } = string.Empty;
        public int vuosimalli { get; set; }
        public Auto(string merkki, string malli, int vuosimalli) 
        {
            this.merkki = SanitizeInput(merkki);
            this.malli = SanitizeInput(malli);
            this.vuosimalli = vuosimalli;
        }

        private string SanitizeInput(string str)
        {
            if (string.IsNullOrEmpty(str)) 
                return str;

            string sanitized = string.Empty;
            for(int i = 0; i < str.Length; i++)
            {
                if(i == 0)
                    sanitized += str[i].ToString().ToUpper();
                else
                    sanitized += str[i].ToString().ToLower();
            }
            return sanitized;
        }
    }
}
