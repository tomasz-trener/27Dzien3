using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10Konstruktory
{
    enum Jednostka
    {
        Celsjusz,
        Kelvin,
        Farenheit
    }

    internal class ManagerPogody
    {
        // domyślnie private 
        private const string adresPodstawowy = "https://www.google.com/search?q=pogoda ";

        private Jednostka jednostka;

        public string AdresPodstawowy => adresPodstawowy;
 
        public string SzukanyZnak { get; set; } = "°"; // moge wyswietlic i zmnieć
        public string ZnakKoncowy { get;  } = ">"; // z zewnarz naszej klasy moge pobrać tę wartośc ale nie moge jej ustawić (readonly)

        public ManagerPogody(Jednostka jednostka)
        {
            this.jednostka = jednostka;
        }

        public double PodajTemperature(string miasto )
        {
            
            
            string adres = adresPodstawowy + miasto;
            WebClient wc = new WebClient();
            string dane = wc.DownloadString(adres);

            int indx = dane.IndexOf(SzukanyZnak);
            int aktualnaPozycja = indx;

            while (dane.Substring(aktualnaPozycja, 1) != ZnakKoncowy)
                aktualnaPozycja--;

            string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja - 1);

            // ewentualna trafnsformacja 
            return transformujTemperature(jednostka, Convert.ToDouble(wynik));
        }

        private double transformujTemperature(Jednostka jednostka, double temp)
        {
            if (jednostka == Jednostka.Celsjusz)
            {
                return temp;
            }

            if (jednostka == Jednostka.Farenheit)
            {
                return (temp * 1.8) + 32;
            }

            if (jednostka == Jednostka.Kelvin)
            {
                return temp + 273.15;
            }


            throw new ArgumentException("Nieznana jednostka");
        }
    }
}
