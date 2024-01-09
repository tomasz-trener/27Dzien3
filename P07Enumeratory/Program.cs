using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Enumeratory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ManagerPogody managerPogody = new ManagerPogody();
            //double temperatra = managerPogody.PodajTemperature("Warszawa", Jednostka.Kelvin);
            //Console.WriteLine(temperatra);

            ManagerPogody manager = new ManagerPogody();
            Console.WriteLine("Podaj miasto");
            string miasto = Console.ReadLine();

            List<Jednostka> jednostki = Enum.GetValues(typeof(Jednostka)).Cast<Jednostka>().ToList();
            Console.WriteLine("Podaj jednostkę, jedną z: " + string.Join(", ",jednostki));

            string jednostka = Console.ReadLine();
            bool czyPoprawana = Enum.TryParse(jednostka, out Jednostka jednostkaEnum);

            if (czyPoprawana)
            {
                try
                {
                    double temperatura = manager.PodajTemperature("Warszawa", jednostkaEnum);
                    Console.WriteLine(temperatura);
                }
                catch (Exception)
                {
                    Console.WriteLine("Nie udało się pobrać temperatury");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna jednostka");

            }
            Console.Read();


        }
    }
}
