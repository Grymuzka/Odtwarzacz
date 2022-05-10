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
            IUtwor u1 = new Utwor(1, "Dom", "Bitamina", "Kawalerka", 56735); //WYWOŁANIE KONSTRUKTORA
            IUtwor u2 = new Utwor(2, "Klopot", "Problem", "Nieznany", 23424);
            IUtwor u3 = new Utwor(3, "Yellow", "Coldplay", "Parachutes", 4456);

            IOdtwarzacz o1 = new Odtwarzacz(50, u1);

            //o1.Playlista.Add(u1);
            //o1.Playlista.Remove(u1);
            //o1.Playlista.Add(u1);
            //o1.Playlista.Add(u2);
            //o1.Playlista.Add(u3);

            //o1.ZapiszPlayliste("playlista.txt");
            o1.Playlista = o1.OdczytajPlayliste("playlista.txt");

            o1.OnOdtworzonoUtwor += OdtworzonoUtwor;

            Console.WriteLine("****************\n");
            Console.WriteLine($"Obecny poziom głośności wynosi: { o1.PoziomGlosnosci} % \n");
            Console.WriteLine("****************");
            o1.OdtworzUtwor(u2);
            o1.OdtworzUtwor(u1);
            o1.OdtworzUtwor(u3);
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
