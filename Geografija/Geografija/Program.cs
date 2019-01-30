using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geografija
{
    class Program
    { public static VrstaJezera Upit()
        {
            Console.WriteLine("Unesite koju vrstu jezera hocete, moze biti prirodno, otkucati 1 ili vestacko, otkucati 2");
            string vrstaStr = Console.ReadLine();
            VrstaJezera vrsta = Konvert(vrstaStr);
            return vrsta;


        }

        public static VrstaJezera Konvert(string vrsta)
        {
            if (vrsta == "") { throw new ArgumentOutOfRangeException(); }
            else {
                switch (vrsta)
                {
                    case "1":
                        return VrstaJezera.prirodno; break;
                    case "2":
                        return VrstaJezera.vestacko; break;
                    default:
                        throw new ArgumentOutOfRangeException();


                }
            }
            
        }

        
        
        static void Main(string[] args)
        {
            JezerskaOblast jo = new JezerskaOblast("nasa jezera", 1000);
            Jezero jez1 = new Jezero("prvo jezero", 100, Upit());
            Ostrvo ost1 = new Ostrvo("ostrvo1", 15);
            Ostrvo ost2 = new Ostrvo("ostrvo2", 4);
            Jezero jez2 = new Jezero("Jezerce", 2, VrstaJezera.vestacko);
            Jezero jez3 = new Jezero("jos jedno jezero", 15, VrstaJezera.prirodno);
            Ostrvo ost3 = new Ostrvo("ostrvo3", 5);
            Jezero jez4 = new Jezero("i jos jedno jezero", 6, Upit());

            jo.Dodaj(jez1);
            jo.Dodaj(jez2);
            jo.Dodaj(jez3);
            jo.Dodaj(jez4);

            jez1.Dodaj(ost1);
            jez1.Dodaj(ost2);
            

            ost2.Dodaj(jez2);

            jez3.Dodaj(ost3);


            

            Console.WriteLine(jo.Naziv + " " + jo.Povrsina + " " + jo.UkupnaPovrsina());
            
        }
    }
}
