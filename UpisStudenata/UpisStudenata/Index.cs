using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpisStudenata
{
    public struct Index
    {
        private int redniBroj;
        private int godinaUpisa;

        public int RedniBroj
        {
            get
            {
                return redniBroj;
            }

            set
            {
                redniBroj = value;
            }
        }

        public int GodinaUpisa
        {
            get
            {
                return godinaUpisa;
            }

            set
            {
                godinaUpisa = value;
            }
        }

        public Index(int redniBroj, int godinaUpisa)
        {
            this.redniBroj = redniBroj;
            this.godinaUpisa = godinaUpisa;
        }
        public override string ToString()
        {
            return this.RedniBroj + "/" + this.GodinaUpisa % 100;
        }
    }
}