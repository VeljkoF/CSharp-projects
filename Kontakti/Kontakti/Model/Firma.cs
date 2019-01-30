using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakti.Model
{
    public class Firma : Kontakt
    {
        public string Naziv { get; set; }
        public int? BrZaposlenih { get; set; }

        public string SkracenoImeFirme()
        {
            return Naziv.Substring(0, 2);
        }



        public override string DisplayName()
        {
            return Naziv;
        }


    }
}
