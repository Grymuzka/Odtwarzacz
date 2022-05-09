using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    public class Utwor : IUtwor
    {
        public int IdUtworu { get; set; }
        public string TytulUtworu { get; set; }
        public string Wykonawca { get; set; }
        public string NazwaPlyty { get; set; }
        public float DlugoscUtworu { get; set; }

        public Utwor(int Id, string Tyt, string Wyk, string Nazwa, float Dlugosc)
        {
            IdUtworu = Id;
            TytulUtworu = Tyt;
            Wykonawca = Wyk;
            NazwaPlyty = Nazwa;
            DlugoscUtworu = Dlugosc;
        }

        public void WyswietlDaneUtworu()
        {
            Console.WriteLine($"{TytulUtworu}, {Wykonawca}, {NazwaPlyty}, {DlugoscUtworu}");
        }
    }
}
