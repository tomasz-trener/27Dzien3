using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            Kalkulator k2; // Deklarujemy zmienną o nazwie 'k2'
                           //, która jest typu Kalkulator 
                           // Nie moge teraz pracować na k2
                           // ta zamienna jest gotowa na to aby do niej 
                           // przypisać nowy obiekt tylu kalkulator 

            k2 = new Kalkulator(); // tworzymy nową instancję klasy kalkulator 
                                   // (nowy obiket) i przypisumey ten obiekt do zmiennej k2

            
            new Kalkulator(); // tworzymy nowy obiekt w pamięci
                              // ale nie mamy do niego uchwytu 

            Kalkulator k3 = k2; // tworzymy zmienną k3, która wskazuje na już
                                // istniejąct obiekt (ten sam na którego wskazuje k2) 

        }
    }
}
