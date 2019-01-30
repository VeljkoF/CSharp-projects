using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geografija
{
    public abstract class GeografskiProstor
    {
        private string naziv;
        private double povrsina;

        public string Naziv
        {
            get
            {
                return naziv;
            }

            // set
            //{
            //    naziv = value;
            //}
        }

        public double Povrsina
        {
            get
            {
                return povrsina;
            }

            set
            {
                povrsina = value;
            }
        }

        public GeografskiProstor(string naziv, double povrsina)
        {
            this.naziv = naziv;
            this.povrsina = povrsina;
        }

        public abstract double UkupnaPovrsina();


    }
}