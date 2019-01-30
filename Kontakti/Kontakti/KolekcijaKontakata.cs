using System;
using Kontakti.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kontakti
{
    public class KolekcijaKontakata
    {
        private string KonekcioniString = @"";
        public List<Kontakt> listaKontakat { get; set; }

        public KolekcijaKontakata()
        {
            listaKontakat = new List<Kontakt>();

        }



        public void CitajBazu()
        {
            using (SqlConnection conn = new SqlConnection(KonekcioniString))
            {
                SqlCommand komanda = conn.CreateCommand();
                komanda.CommandText = @"SELECT * FROM Kontakti";
                conn.Open();

                using (SqlDataReader read = komanda.ExecuteReader())
                {
                    
                    while (read.Read())
                    {
                        if (read["Naziv"] != null)
                        {
                            Firma k = new Firma();
                            k.Id = (int) read["IDKontakt"];
                            k.Naziv = read["Naziv"] as string;
                            k.BrZaposlenih =(int) read["BrojZaposlenih"];

                            this.listaKontakat.Add(k);
                           
                        }
                        else{
                            Osoba o = new Osoba();

                            o.Id = (int) read["IDKontakt"];
                            o.Ime = read["Ime"] as string;
                            o.Prezime = read["Prezime"] as string;
                            o.DatumRodjenja = read["DatumRodjenja"] as DateTime?;

                            this.listaKontakat.Add(o);
                            
                        }
                    }
                }
            }
        }
    }
}
