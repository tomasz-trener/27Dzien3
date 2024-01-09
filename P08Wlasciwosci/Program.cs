using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08Wlasciwosci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();
            kalkulator.Kolor = "czerwony";

            Console.WriteLine(kalkulator.Kolor);

            // wcześniej już korzystaliśmy z właściowości 
            List<string> lista = new List<string>();
            int liczbaElementow = lista.Count;
            string s = "ala ma kota";
            int dlugosc = s.Length;


            Czlowiek czlowiek = new Czlowiek();

            czlowiek.Nazwisko = "Kowalski";

            czlowiek.Imie = "Jan";

            Console.WriteLine(czlowiek.Imie); //JAN

            Console.WriteLine(czlowiek.ImieNazwisko);

            czlowiek.ImieNazwisko = "Adam nowak";
        }
    }
}
