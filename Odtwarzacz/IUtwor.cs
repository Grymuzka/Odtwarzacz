using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    internal interface IUtwor
    {
        int Id { get; set; }
        string Tyt { get; set; }
        string Wyk { get; set; }
        string Nazwa { get; set; }
        float Dlugosc { get; set; }
        void WyswietlDaneUtworu();
    }
}
