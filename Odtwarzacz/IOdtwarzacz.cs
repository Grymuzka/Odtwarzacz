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
        void ZwiekszGlosnosc();
        void ZmniejszGlosnosc();
        IUtwor OdtwarzanyUtwor { get; set; }
        IUtwor OdtworzUtwor(int idUtworu);
        List<IUtwor> Playlista { get; set; }
        string PlikZHistoria { get; set; }
        List<IUtwor> Historia { get; set; }
        void ZapiszHistorieWPliku();
        void ZapiszPlayliste(string nazwaPliku);
        List<IUtwor> OdczytajPlayliste(string nazwaPliku);



    }
}
