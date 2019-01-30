using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softwer
{
    public class Softwer
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int GodinaIzdanja { get; set; }
        public decimal? Cena { get; set; }

        public override string ToString()
        {
            return this.Id + " " + this.Naziv + " " + this.GodinaIzdanja + " " + this.Cena;
        }
    }
}
