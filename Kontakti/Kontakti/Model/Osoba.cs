using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakti.Model
{
    public class Osoba : Kontakt
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }



        public override string DisplayName()
        {
            return Ime + ", " + Prezime;
        }
    }
}
