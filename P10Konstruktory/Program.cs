﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10Konstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator("naukowy");

            //k.Tryb = "naukowy";

            string wynik = k.Policz(10, 3);


            ManagerPogody mp = new ManagerPogody(Jednostka.Farenheit);

            double temp1 = mp.PodajTemperature("warszawa");
            double temp2 = mp.PodajTemperature("kraków");

            Console.ReadKey();
        }

        // Podsumowanie: 
        // Klasy mogą się składać z:
        // 1) pola -> prywatne cechy obiektu 
        // 2) właściwości -> publiczne cechy obiektu 
        // 3) konstruktory -> kontrolują sposób tworzenia obiektu 
        // 4) metody -> realizacja zadań 
    }
}
