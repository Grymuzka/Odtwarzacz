using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    public class Utwor : IUtwor
    {
        public int Id { get; set; }
        public string Tyt { get; set; }
        public string Wyk { get; set; }
        public string Nazwa { get; set; }
        public float Dlugosc { get; set; }

        public Utwor(int IdUtworu, string Tytul, string Wykonawca, string NazwaPlyty, float DlugoscUtworu)
        {
            Id = IdUtworu;
            Tyt = Tytul;
            Wyk = Wykonawca;
            Nazwa = NazwaPlyty;
            Dlugosc = DlugoscUtworu;
        }

        public void WyswietlDaneUtworu()
        {
            Console.WriteLine($"{Tyt}, {Wyk}, {Nazwa}, {Dlugosc}");
        }
    }
}
