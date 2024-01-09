using P05ZadanieManagerTekstu.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieManagerTekstu
{
    internal class ManagerTekstu
    {
        public string ZnajdzNajdluzszyWyraz(string zdanie)
        {
            if (zdanie.Length < 1)
                throw new ZbytKroktkieZdanieException();


            string[] wyrazy = zdanie.Split(' ');
            string aktualnieNajdluzszy = string.Empty;
            foreach (var w in wyrazy)
            {
                if (w.Length > aktualnieNajdluzszy.Length)
                {
                    aktualnieNajdluzszy = w;
                }
            }

            return aktualnieNajdluzszy;
        }

        public string[] ZnajdzWszystkieNajdluzszeWyrazy(string zdanie)
        {
            if (string.IsNullOrWhiteSpace(zdanie))
            {
                throw new ArgumentException("Zdanie nie może być puste lub zawierać tylko białe znaki");
            }

            string najdluzszy = ZnajdzNajdluzszyWyraz(zdanie);
            return znajdzWyrazyOPodajDlugosci(najdluzszy.Length, zdanie);
        }

        private string[] znajdzWyrazyOPodajDlugosci(int dlugosc, string zdanie)
        {
            HashSet<string> znalezione = new HashSet<string>(); // nie chcemy powtorzen 

            foreach (var w in zdanie.Split(' '))
            {
                if (w.Length == dlugosc)
                {
                    znalezione.Add(w);
                }
            }

            return znalezione.ToArray();
        }
 
    }
}
