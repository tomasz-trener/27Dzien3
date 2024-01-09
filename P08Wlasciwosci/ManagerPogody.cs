using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08Wlasciwosci
{
    internal class ManagerPogody
    {
        // domyślnie private 
        private const string adresPodstawowy = "https://www.google.com/search?q=pogoda ";


        public string AdresPodstawowy => adresPodstawowy;
        //public string AdresPodstawowy
        //{
        //    get
        //    {
        //        return adresPodstawowy;
        //    }
        //}

        public string SzukanyZnak { get; set; } = "°"; // moge wyswietlic i zmnieć
        public string ZnakKoncowy { get;  } = ">"; // z zewnarz naszej klasy moge pobrać tę wartośc ale nie moge jej ustawić (readonly)


        public double PodajTemperature(string miasto, string jednostka)
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

        private double transformujTemperature(string jednostka, double temp)
        {
            if (jednostka == "Celsjusz")
            {
                return temp;
            }

            if (jednostka == "Farenheit")
            {
                return (temp*1.8)+32;
            }

            if (jednostka == "Kelvin")
            {
                return temp + 273.15;
            }

            throw new ArgumentException("Nieznana jednostka");
        }
    }
}
