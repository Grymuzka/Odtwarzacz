using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    internal interface IOdtwarzacz
    {
        int PoziomGlosnosci { get; set; }
        void ZwiekszGloscnosc();
        void ZmniejszGlosnosc();
        IUtwor OdtwarzanyUtwor { get; set; }
        void ZmienUtwor();
        List<IUtwor> Playlista { get; set; }
        void DodajLubUsunUtworDoPlaylisty();
        List<IUtwor> Historia { get; set; }
        void DodajUtworDoHistorii();



    }
}
