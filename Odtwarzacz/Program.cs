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
            IUtwor u1 = new Utwor("Dom", "Bitamina", "Kawalerka", new TimeSpan(0,3,53)); //WYWOŁANIE KONSTRUKTORA
            IUtwor u2 = new Utwor("Klopot", "Problem", "Nieznany", new TimeSpan(0, 3, 12));
            IUtwor u3 = new Utwor("Yellow", "Coldplay", "Parachutes", new TimeSpan(0, 3, 34));

            IOdtwarzacz o1 = new Odtwarzacz(50, u1);

            o1.Playlista.Add(u1);
            o1.Playlista.Remove(u1);
            o1.Playlista.Add(u1);
            o1.Playlista.Add(u2);
            o1.Playlista.Add(u3);

            //o1.ZapiszPlayliste("playlista.txt");
            o1.Playlista = o1.OdczytajPlayliste("playlista.txt");

            o1.OnOdtworzonoUtwor += OdtworzonoUtwor;

            Console.WriteLine("****************\n");
            Console.WriteLine($"Obecny poziom głośności wynosi: { o1.PoziomGlosnosci} % \n");
            Console.WriteLine("****************");
            o1.OdtworzUtwor(o1.Playlista[0]);
            o1.OdtworzUtwor(o1.Playlista[2]);
            o1.OdtworzUtwor(o1.Playlista[1]);
            //o1.KolejnyUtwor();
            o1.WyswietlDlugoscPlaylisty();

            Console.ReadKey();
        }

        public static void OdtworzonoUtwor(IUtwor u)
        {
            IUtwor utwor = null;
            if (u is Utwor)
            {
                utwor = u as Utwor;
            }
            Console.WriteLine($" Aktualnie odtwarzany: \n  Tytuł: {utwor.TytulUtworu}\n  Autor: {utwor.Wykonawca} \n  Nazwa płyty: {utwor.NazwaPlyty} \n  Czas trwania: {utwor.DlugoscUtworu}\n");
        }

    }
}
