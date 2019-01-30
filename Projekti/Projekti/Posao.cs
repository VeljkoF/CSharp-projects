using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekti
{
    public class Posao : Jedinica
    {
        private decimal cenaPosao;

        public decimal CenaPosao
        {
            get
            {
                return cenaPosao;
            }

            set
            {
                cenaPosao = value;
            }
        }
        public Posao(decimal cenaPosao = 0)
        {
            CenaPosao = cenaPosao;
        }
        
        public override decimal UkupnaCena()
        {
            return CenaPosao;
        }
    }
}