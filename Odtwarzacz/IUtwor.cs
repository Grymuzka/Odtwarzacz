using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    public interface IUtwor
    {
        int IdUtworu { get; set; }
        string TytulUtworu { get; set; }
        string Wykonawca { get; set; }
        string NazwaPlyty { get; set; }
        float DlugoscUtworu { get; set; }
    }
}
