using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekti
{
    public abstract class Jedinica
    {
        private string naziv;

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
        public Jedinica()
        {

        }
        public void ImePromena(string naziv)
        {
            Naziv = naziv;
        }

        public Jedinica(string naziv)
        {
            Naziv = naziv;
        }

        public abstract decimal UkupnaCena();
    }
}