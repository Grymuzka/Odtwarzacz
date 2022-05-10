using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    public interface IUtwor
    {
        string TytulUtworu { get; set; }
        string Wykonawca { get; set; }
        string NazwaPlyty { get; set; }
        TimeSpan DlugoscUtworu { get; set; }
    }
}
