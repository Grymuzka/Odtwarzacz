using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    internal interface IUtwor
    {
        int IdUtworu { get; set; }
        string Tytul { get; set; }
        string Wykonawca { get; set; }
        string NazwaPlyty { get; set; }
        DateTime DlugoscUtworu { get; set; }
    }
}
