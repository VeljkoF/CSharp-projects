using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Projekat p1 = new Projekat("Proj1", 300);
            Aktivnost a1 = new Aktivnost();
            a1.CenaUpravljanjapromena(100);
            a1.ImePromena("Akt1");
            Posao pos1 = new Posao(100);
            pos1.ImePromena("Pos11");
            Aktivnost a2 = new Aktivnost();
            a2.CenaUpravljanjapromena(50);
            a2.ImePromena("Akt12");
            Console.WriteLine("Unesite cenu posla");
            string cena = Console.ReadLine();
            decimal c = Convert.ToDecimal(cena);
            Posao pos2 = new Posao(c);
            pos2.ImePromena("Posao131");
            Posao pos3 = new Posao(200);
            pos3.ImePromena("Posao132");
            p1.Dodaj(a1);
            a1.Dodaj(pos1);
            a1.Dodaj(a2);
            a2.Dodaj(pos2);
            a2.Dodaj(pos3);
            Aktivnost a3 = new Aktivnost();
            a3.ImePromena("Akt2");
            a3.CenaUpravljanjapromena(70);
            Posao pos4 = new Posao();
            pos4.ImePromena("Pos21");
            Posao pos5 = new Posao(150);
            pos5.ImePromena("Pos22");
            p1.Dodaj(a3);
            a3.Dodaj(pos4);
            a3.Dodaj(pos5);
            Console.WriteLine(p1.UkupnaCenaProjekta());
            
        }
    }
}
