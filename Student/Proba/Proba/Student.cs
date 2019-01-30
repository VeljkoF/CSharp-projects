using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
   public class Student : Osoba
    {
        public int GodianaUpisa { get; set; }
        public int GodinaStudija { get; set; }

        public Student()
        {

        }
        public Student(int id, string ime, string prezime, DateTime darumRodjenja, int godinaUpisa, int godinaStudije)
            :base(id, ime, prezime, darumRodjenja)
        {
            this.GodianaUpisa = godinaUpisa;
            this.GodinaStudija = godinaStudije;
        }
        public override string ToString()
        {
            return base.ToString() + ", " + this.GodianaUpisa + ", " + this.GodinaStudija;
        }
    }
}
