using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCsharp
{   public enum PravoPristupa
    {
        privatno, zasticeno, javno
    }
    public class Klasa : Element
    {
        private PravoPristupa pristup = PravoPristupa.javno;

        public PravoPristupa Pristup
        {
            get
            {
                return pristup;
            }

            set
            {
                pristup = value;
            }
        }
        public Klasa()
        {
            
        }
        public Klasa(PravoPristupa pristup, string naziv) : base(naziv)
        {
            this.pristup = pristup;
        }
        public override void Prevod()
        {
            Console.WriteLine("Klasa " + Naziv + "se prevodi...");
        }
    }
}