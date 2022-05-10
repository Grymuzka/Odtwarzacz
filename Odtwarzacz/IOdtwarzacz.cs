using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    public interface IOdtwarzacz
    {
        int PoziomGlosnosci { get;  set; }
        void ZwiekszGlosnosc();
        void ZmniejszGlosnosc();
        IUtwor OdtwarzanyUtwor { get; set; }
        OdtworzonoUtwor OnOdtworzonoUtwor { get; set; }
        IUtwor OdtworzUtwor(IUtwor utwor);
        void KolejnyUtwor();
        void PoprzedniUtwor();
        List<IUtwor> Playlista { get; set; }
        void WyswietlDlugoscPlaylisty();
        string PlikZHistoria { get; set; }
        List<IUtwor> Historia { get; set; }
        void ZapiszHistorieWPliku();
        void ZapiszPlayliste(string nazwaPliku);
        List<IUtwor> OdczytajPlayliste(string nazwaPliku);
    }
}
