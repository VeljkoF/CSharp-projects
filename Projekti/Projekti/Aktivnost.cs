using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekti
{
    public class Aktivnost : Jedinica
    {
        private List<Jedinica> jedinica = new List<Jedinica>();
        private decimal cenaUpravljanja = 50;

        public List<Jedinica> Jedinica
        {
            get
            {
                return jedinica;
            }

            private set
            {
                jedinica = value;
            }
        }

        public decimal CenaUpravljanja
        {
            get
            {
                return cenaUpravljanja;
            }

            private set
            {
                cenaUpravljanja = value;
            }
        }
        public void CenaUpravljanjapromena(decimal cena)
        {
            CenaUpravljanja = cena;
        }
        public override decimal UkupnaCena()
        {
            decimal ukupnaCenaAktivnosti = 0;
            for (int i = 0; i < jedinica.Count; i++)
            {
                ukupnaCenaAktivnosti += jedinica[i].UkupnaCena();
            }
            return ukupnaCenaAktivnosti + CenaUpravljanja;
        }    

        public void Dodaj(Jedinica j)
        {
            jedinica.Add(j);
        }
    }
}