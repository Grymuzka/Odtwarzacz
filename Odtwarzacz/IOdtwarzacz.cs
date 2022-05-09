using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    public interface IOdtwarzacz
    {
        int PoziomGlosnosci { get; set; }
        void ZmienGloscnosc(int wartosc);
        IUtwor OdtwarzanyUtwor { get; set; }
        void OdtworzUtwor(int idUtworu);
        List<IUtwor> Playlista { get; set; }
        void DodajLubUsunUtwor();
        string PlikZHistoria { get; set; }
        List<IUtwor> Historia { get; set; }
        void ZapiszHistorieWPliku();



    }
}
