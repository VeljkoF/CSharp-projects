using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpisStudenata
{
    public enum StudijskiProgram
    {
        IT, TK, PBT
    }

    public enum StudentStatusFinansiranja
    {
        Budzet, Samofinansiranje
    }

    public class Student
    {
        public Index Index { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public DateTime DatumRodjenje { get; set; }

        public int PriznatiESPB { get; set; }

        public StudijskiProgram StudijskiProgram { get; set; }

        public StudentStatusFinansiranja StatusFInansiranja { get; set; }

        public int Starost
        {
            get
            {
                DateTime sada = DateTime.Now;
                DateTime rodjendan = new DateTime(sada.Year, this.DatumRodjenje.Month, this.DatumRodjenje.Day);
                int razlika = sada.Year - this.DatumRodjenje.Year;
                if (rodjendan < sada)
                    return razlika;
                else return razlika - 1;

            }
        }
    }
}