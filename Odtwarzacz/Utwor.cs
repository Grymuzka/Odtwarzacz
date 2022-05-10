using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    public class Utwor : IUtwor
    {
        public string TytulUtworu { get; set; }
        public string Wykonawca { get; set; }
        public string NazwaPlyty { get; set; }
        public TimeSpan DlugoscUtworu { get; set; } //MOWA O TEJ ZMIENNEJ

        public Utwor(string tyt, string wyk, string nazwa, TimeSpan dlugosc)
        {
            TytulUtworu = tyt;
            Wykonawca = wyk;
            NazwaPlyty = nazwa;
            DlugoscUtworu = dlugosc;
        }

    }
}
