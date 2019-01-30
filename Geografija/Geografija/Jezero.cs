using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geografija
{public enum VrstaJezera { prirodno,vestacko}
    public class Jezero : GeografskiProstor
    {
        private VrstaJezera vrstaJez;
        private List<Ostrvo> ostrva = new List<Ostrvo>();

        public VrstaJezera VrstaJez
        {
            get
            {
                return vrstaJez;
            }

            set
            {
                vrstaJez = value;
            }
        }

        public List<Ostrvo> Ostrva
        {
            get
            {
                return ostrva;
            }

            //set
            //{
            //    ostrva = value;
            //}
        }

        public Jezero(string  naziv, double povrsina,VrstaJezera jezero):base(naziv, povrsina)
        {
            this.vrstaJez = jezero;
        }

        public override double UkupnaPovrsina()
        {
            double povrsinaJezera = Povrsina;
            for (int i = 0; i < ostrva.Count; i++)
            {
                povrsinaJezera = povrsinaJezera - ostrva[i].UkupnaPovrsina();
            }
            return povrsinaJezera;
        }

        //public override double UkupnaPovrsina()
        //{
        //   double PovrsinaJezera = Povrsina;
        //    for (int i = 0; i < ostrva.Count; i++)
        //    {
        //        PovrsinaJezera -= ostrva[i].UkupnaPovrsina();
        //    }
        //    return PovrsinaJezera;
        //}

        public void Dodaj(Ostrvo o) {

            ostrva.Add(o);
        }
    }
}