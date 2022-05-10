using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Odtwarzacz 
{
    public delegate void OdtworzonoUtwor(IUtwor u);
    public class Odtwarzacz : IOdtwarzacz
    {
        [JsonIgnore]
        public int PoziomGlosnosci { get; set; } 
        [JsonIgnore]
        public IUtwor OdtwarzanyUtwor { get; set; }

        [JsonIgnore]
        private List<IUtwor> playlista;
        [JsonIgnore]
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

        public void WyswietlDlugoscPlaylisty()
        {
            playlista = this.Playlista;
            TimeSpan dlugoscPlaylisty = new TimeSpan(0, 0, 0);
            foreach(IUtwor u in playlista)
            {
                dlugoscPlaylisty += u.DlugoscUtworu;
            }

            Console.WriteLine($"Czas trwania playlisty wynosi : {dlugoscPlaylisty}");
        }

        [JsonIgnore]
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

        [JsonIgnore]
        public OdtworzonoUtwor OnOdtworzonoUtwor { get; set; }
        public IUtwor OdtworzUtwor(IUtwor utwor)
        {
            foreach (IUtwor u in Playlista) 
            {
                if(u == utwor)
                {
                    OdtwarzanyUtwor = u;
                    break;
                }
            }
            Historia.Add(OdtwarzanyUtwor);
            ZapiszHistorieWPliku();
            OnOdtworzonoUtwor?.Invoke(utwor);

            return OdtwarzanyUtwor;
        }
        public void KolejnyUtwor()
        {
            int i = 0;
            int index = 0;
            foreach (IUtwor u in Playlista)
            {
                if (u == OdtwarzanyUtwor)
                {
                    index = i;
                }
                i++;
            }

            if ((index + 1) <= Playlista.Count)
                OdtworzUtwor(Playlista[index + 1]);
            else Console.WriteLine("Brak następnego utworu");
        }
        public void PoprzedniUtwor()
        {
            int i = 0;
            int index = 0;
            foreach (IUtwor u in Playlista)
            {
                if (u == OdtwarzanyUtwor)
                {
                    index = i;
                }
                i++;
            }

            if ((index - 1) >= 0)
                OdtworzUtwor(Playlista[index - 1]);
            else Console.WriteLine("Brak poprzedniego utworu");
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
        public void ZapiszPlayliste(string nazwaPliku)
        {
            string playlistaTekst = JsonConvert.SerializeObject(Playlista);
            System.IO.File.WriteAllText(nazwaPliku, playlistaTekst);  //serializacja na tekst
        }
        public List<IUtwor> OdczytajPlayliste(string nazwaPliku)
        {
            string playlistaTekst = System.IO.File.ReadAllText(nazwaPliku);
            List<IUtwor> r = new List<IUtwor>();
            foreach (IUtwor u in JsonConvert.DeserializeObject<List<Utwor>>(playlistaTekst))
            {
                r.Add(u);
            }
            return r;
        }

        public Odtwarzacz(int glosnosc, IUtwor odtutwor)
        {
            PoziomGlosnosci = glosnosc;
            OdtwarzanyUtwor = odtutwor;
        }

    }
}

