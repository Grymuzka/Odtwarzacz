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

        public void OdtworzUtwor(int idUtworu)
        {
            OdtwarzanyUtwor.Id = idUtworu;
            Historia.Add(OdtwarzanyUtwor);
            ZapiszHistorieWPliku();
            OnOdtworzonoUtwor?.Invoke(this);
        }
        public void ZapiszHistorieWPliku()
        {
            string tresc = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText("historia.txt", tresc);
        }

        public void DodajLubUsunUtwor()
        {
            throw new NotImplementedException();
        }

        public void ZmienGloscnosc(int wartosc)
        {
            PoziomGlosnosci += wartosc;
        }

    }
}

