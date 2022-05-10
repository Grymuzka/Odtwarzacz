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
            IUtwor u3 = new Utwor(3, "Yellow", "Coldplay", "Parachutes", 44423);

            IOdtwarzacz o1 = new Odtwarzacz(50, u1);

            //o1.Playlista.Add(u1);
            //o1.Playlista.Remove(u1);
            //o1.Playlista.Add(u1);
            //o1.Playlista.Add(u2);
            //o1.Playlista.Add(u3);

            //o1.ZapiszPlayliste("playlista.txt");
            o1.Playlista = o1.OdczytajPlayliste("playlista.txt");

            o1.OdtworzUtwor(3);
            o1.OdtworzUtwor(2);
            o1.OdtworzUtwor(3);

            Console.WriteLine("**********************************************************");

            Console.WriteLine($"Obecny poziom głośności wynosi: { o1.PoziomGlosnosci} %");

            o1.WyswietlDaneOdtwarzanegoUtworu();

            Console.ReadKey();
        }
        
    }
}
