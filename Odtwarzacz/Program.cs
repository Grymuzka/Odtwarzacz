using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Odtwarzacz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUtwor u1 = new Utwor(1, "Dom", "Bitamina", "Kawalerka", 22230);
            IUtwor u2 = new Utwor(2, "Klopot", "Problem", "Nieznany", 23424);

            u2.WyswietlDaneUtworu();

            IOdtwarzacz o1 = new Odtwarzacz(50, u1);

            //o1.Playlista.Add(u1);
            //o1.Playlista.Remove(u1);
            //o1.Playlista.Add(u1);
            //o1.Playlista.Add(u2);

            //o1.ZapiszPlayliste("playlista.txt");
            o1.Playlista = o1.OdczytajPlayliste("playlista.txt");

            Console.WriteLine(o1.Playlista[1].NazwaPlyty);

            Console.WriteLine("**********************************************************");

            Console.WriteLine($"Obecny poziom głośności wynosi: { o1.PoziomGlosnosci} %");

            Console.ReadKey();
        }
        
    }
}
//komentarz123
