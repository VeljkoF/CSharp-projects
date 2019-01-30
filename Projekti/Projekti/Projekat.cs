using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekti
{
    public class Projekat
    {
        private string naziv;
        private decimal cenaProjekta;
        List<Aktivnost> aktivnost = new List<Aktivnost>();

        public string Naziv
        {
            get
            {
                return naziv;
            }

            private set
            {
                naziv = value;
            }
        }

        public decimal CenaProjekta
        {
            get
            {
                return cenaProjekta;
            }

            private set
            {
                cenaProjekta = value;
            }
        }

        public void NazivPromena(string naziv)
        {
            Naziv = naziv;
        }
        public void CenaPromena(decimal cena)
        {
            CenaProjekta = cena;
        }
        public Projekat(string naziv, decimal cena = 0)
        {
            Naziv = naziv;
            CenaProjekta = cena;
        }
        public void Dodaj(Aktivnost a)
        {
            aktivnost.Add(a);
        }
        public void Ukloni(int index)
        {
            aktivnost.RemoveAt(index);
        }
        public Aktivnost Dohvati(int index)
        {
            return aktivnost.ElementAt(index);
        }
        public int Izbroji
        {

            get
            {
                int broj = 0;
                for (int i = 0; i < aktivnost.Count; i++)
                {
                    broj++;
                }
                return broj;
            }
        }
        public decimal UkupnaCenaProjekta()
        {
            
                decimal ukupnaCena = 0;
                for (int i = 0; i < aktivnost.Count; i++)
                {
                    ukupnaCena += aktivnost[i].UkupnaCena();
                }
                return ukupnaCena + CenaProjekta;

            
        }
    }
}