using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    public class Asociatie
    {
        private const char separator = ',';
        public string nume_acronim;
        public string nume_asociatie;
        public string data_aniversare;

        public Asociatie()
        {
            nume_acronim = nume_asociatie = data_aniversare = string.Empty;
        }
        public Asociatie(string NumeAcr, string NumeAs, string DataAniv)
        {
            this.nume_acronim= NumeAcr;
            this.nume_asociatie= NumeAs;
            this.data_aniversare= DataAniv;
        }

        public Asociatie(string linieFisier)
        {
            var dateFisier = linieFisier.Split(separator);
            nume_acronim=dateFisier[0];
            nume_asociatie=dateFisier[1];
            data_aniversare=dateFisier[2];
        }
        public string ConvSirFisier()
        {
            string obFis=string.Format("{1}{0}{2}{0}{3}{0}{4}{0}", separator, nume_acronim, nume_asociatie, data_aniversare);
            return obFis;
        }
        public string getAcronim()
        {
            return nume_acronim;
        }
        public string getNume()
        {
            return nume_asociatie;
        }
        public string getAniversare()
        { 
            return data_aniversare;
        }
    }
}
