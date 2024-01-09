using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            char b = 'b';
            string c = "hej"; // string jest wyjatkiem bo jest klasa ale przekazujemy wartosci przez kopie 
            double d = 5.6;
            bool e = false;

            int a2 = a; // przekazanie wartosci
            a = 7;
            // pytanie co jest w a2?  a2 = 6 


            WebClient wc = new WebClient();
            DateTime dt = new DateTime();
            DateTime dt2 = new DateTime(2023, 9, 15);

            StringBuilder sb = new StringBuilder();
            sb.Append("ala ");
            sb.Append("ma ");
            sb.Append("kota");
            string s = sb.ToString();

            StringBuilder sb2 = sb; // przekazanie referencji 
            sb.Append(" i psa");

            // pytnanie co bedzie w sb2 ? sb2 = "ala ma kota i psa 



            DateTime dt3 = dt2;
            dt2=dt2.AddDays(1);
            // co znajduje sie w dt3 ? odp: 15
        }
    }
}
