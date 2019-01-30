using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geografija
{
    public class Ostrvo : GeografskiProstor
    {
        private List<Jezero> jezera = new List<Jezero>();

        public List<Jezero> Jezera
        {
            get
            {
                return jezera;
            }

            //set
            //{
            //    jezera = value;
            //}
        }

        public Ostrvo(string naziv, double povrsina):base(naziv, povrsina)
        {

        }

        public override double UkupnaPovrsina()
        {
            double povrsinaJezera = Povrsina;
            for (int i = 0; i < jezera.Count; i++)
            {
                povrsinaJezera = povrsinaJezera + jezera[i].UkupnaPovrsina();
            }
            return povrsinaJezera;
        }


        //public override double UkupnaPovrsina()
        //{
        //    double PovrsinaJezera=Povrsina;
        //    for (int i = 0; i < jezera.Count; i++)
        //    {
        //        PovrsinaJezera += jezera[i].UkupnaPovrsina();
        //    }
        //    return PovrsinaJezera;
        //}

        public void Dodaj(Jezero j) {

            jezera.Add(j);
}
    }
}