using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }

        public Osoba()
        {

        }
        public Osoba(int id, string ime,  string prezime, DateTime datumRodjenja)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
        }

        public string Inicijali() 
        {
            return this.Ime[0] + ". " + this.Prezime[0] + ". "; 
        }

        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
