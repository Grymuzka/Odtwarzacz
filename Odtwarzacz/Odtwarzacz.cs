using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Odtwarzacz 
{
    public delegate void OdtworzonoUtwor(object u);
    public class Odtwarzacz : IOdtwarzacz
    {
        public int PoziomGlosnosci { get; set; }
        public IUtwor OdtwarzanyUtwor { get; set; }

        private List<IUtwor> playlista;
        public List<IUtwor> Playlista
        {
            get
            {
                if (playlista == null)
                    playlista = new List<IUtwor>();
                return playlista;
            }
            set
            {
                playlista = value;
            }
        }

        public string PlikZHistoria { get; set; }

        private List<IUtwor> historia;
        public List<IUtwor> Historia
        {
            get
            {
                if (historia == null)
                    historia = new List<IUtwor>();
                return historia;
            }
            set
            {
                historia = value;
            }
        }

        public OdtworzonoUtwor OnOdtworzonoUtwor { get; set; }

        public IUtwor OdtworzUtwor(int idUtworu)
        {
            OdtwarzanyUtwor.IdUtworu = idUtworu;
            Historia.Add(OdtwarzanyUtwor);
            ZapiszHistorieWPliku();
            OnOdtworzonoUtwor?.Invoke(this);

            return OdtwarzanyUtwor;
        }
        public void ZapiszHistorieWPliku()
        {
            string tresc = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText("historia.txt", tresc);
        }

        public void ZwiekszGlosnosc()
        {
            PoziomGlosnosci += 1;
            if (PoziomGlosnosci > 100) 
                PoziomGlosnosci = 100;
        }
        public void ZmniejszGlosnosc()
        {
            PoziomGlosnosci -= 1;
            if (PoziomGlosnosci < 0)
                PoziomGlosnosci = 0;
        }

        public Odtwarzacz(int glosnosc, IUtwor odtutwor)
        {
            PoziomGlosnosci = glosnosc;
            OdtwarzanyUtwor = odtutwor;
        }


        public void ZapiszPlayliste(string nazwaPliku)
        {
            string playlistaTekst = JsonConvert.SerializeObject(Playlista);
            System.IO.File.WriteAllText(nazwaPliku, playlistaTekst);  //serializacja na tekst
        }

        public List<IUtwor> OdczytajPlayliste(string nazwaPliku)
        {
            string playlistaTekst = System.IO.File.ReadAllText(nazwaPliku);
            return JsonConvert.DeserializeObject<List<IUtwor>>(playlistaTekst);
        }

    }
}

