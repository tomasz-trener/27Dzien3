using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Wlasciwosci
{
    internal class Czlowiek
    {
        public string Nazwisko { get; set; } // Właściwość 

        private string imie; // pole 

        private int wzrost; // domyślna wartość to 0

        public string Imie
        {
            get
            {
                return imie.ToUpper();
            }
            set
            {
                imie = value;
            }
        }

        public string ImieNazwisko
        {
            get
            {
                string s1 = imie.ToUpper();
                string s2 = Nazwisko.ToUpper();

                return s1 + " " + s2;
            }
            set
            {
                string[] s= value.Split(' ');
                imie = s[0];
                Nazwisko = s[1];
            }
        }


        // przykłądowa metoda:
        public void Idz(int ileMetrow)
        {

        }

        public string PrzedstawSie()
        {
            return "Nazywam sie" + imie + " " + Nazwisko;
        }

    }
}
