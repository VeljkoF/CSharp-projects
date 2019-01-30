using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    public class KonekcijaOsoba
    {
        private string strKonekcije = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Veljko\Desktop\bla\Osobe\Osobe.mdf;Integrated Security=True;Connect Timeout=30";
        public List<Osoba> ListaOsoba { get; private set; }

        public KonekcijaOsoba()
        {
            ListaOsoba = new List<Osoba>();
        }

        public void CitajBazu()
        {
            using (SqlConnection konekcija = new SqlConnection(strKonekcije))
            {
                SqlCommand komanda = konekcija.CreateCommand();

                komanda.CommandText = @"SELECT o.idOsoba, o.Ime, o.Prezime, o.DatumRodjenja, s.IdOsoba as IdStudent, s.GodinaUpisa, s.GodinaStudija
                                        FROM Osoba as o LEFT OUTER JOIN Student as s ON o.IdOsoba = s.IdOsoba";

                konekcija.Open();

                using (SqlDataReader read = komanda.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Osoba osoba = null;

                        if (!read.IsDBNull(read.GetOrdinal("IdStudent")))
                        {
                            osoba = new Student();
                            ((Student)osoba).GodianaUpisa = (int)read["GodinaUpisa"];
                            ((Student)osoba).GodinaStudija = (int)read["GodinaStudija"];
                        }
                        else
                        {
                            osoba = new Osoba();
                        }
                        osoba.Id = (int)read["idOsoba"];
                        osoba.Ime = read["Ime"] as string;
                        osoba.Prezime = read["Prezime"] as string;
                        osoba.DatumRodjenja = read["DatumROdjenja"] as DateTime?;

                        this.ListaOsoba.Add(osoba);
                    }
                }
            }
        }
        public void ObrisiOsobe()
        {
            for (int i = 0; i < ListaOsoba.Count; i++)
            {
                if (ListaOsoba[i].DatumRodjenja == null)
                {
                    ListaOsoba.RemoveAt(i--);
                }
            }
            using (SqlConnection konekcija = new SqlConnection(strKonekcije))
            {
                SqlCommand komanda = konekcija.CreateCommand();

                komanda.CommandText = @"DELETE FROM Osoba WHERE DatumRodjenja IS NULL";

                konekcija.Open();

                komanda.ExecuteNonQuery();
                
            }
        }
        public Student[] PrikaziStudente()
        {
            List<Student> studenti = new List<Student>();
            foreach (Osoba osoba in this.ListaOsoba)
            {
                if (osoba is Student)
                {
                    Student student = osoba as Student;
                    DateTime danas = DateTime.Now;
                    int tekucaSkolsaGodina = danas.Month < 10 ? danas.Year - 1 : danas.Year;
                    if (student.GodianaUpisa < tekucaSkolsaGodina)
                    {
                        studenti.Add(student);
                    }
                }
            }
            return studenti.ToArray();
            
        }
    }
}
