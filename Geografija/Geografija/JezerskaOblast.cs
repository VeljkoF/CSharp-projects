using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geografija
{
    public class JezerskaOblast : GeografskiProstor
    {
        private List<Jezero> jezera = new List<Jezero>();

        public void Dodaj(Jezero jez)
        {

            jezera.Add(jez);
        }

        public Jezero Dohvati(int poz) {

            return jezera.ElementAt(poz);
        }

        public int UkupnoJezera()
        {
            return jezera.Count();

        }


        public JezerskaOblast(string naziv, double povrsina):base(naziv, povrsina)
        {

        }





        public override double UkupnaPovrsina()
        {
            double povrsina = 0;
            for (int i = 0; i < jezera.Count; i++)
            {
                povrsina += jezera[i].UkupnaPovrsina();
            }
            return povrsina;
        }
    }
}