using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softwer
{
    class KonekcijaSoftwer
    {
        private string strKon = @"";

        public List<Softwer> listaSoftwer { get; set; }

        public KonekcijaSoftwer()
        {
            listaSoftwer = new List<Softwer>();
        }
        public void CitajBazu()
        {
            using (SqlConnection kon = new SqlConnection(strKon))
            {
                SqlCommand kom = kon.CreateCommand();
                kom.CommandText = @"SELECT s.IDSoftwer, s.Naziv, s.GodinaIzdanja, s.Cena, i.IDSoftwer as IDIgra, i.Zanr
                                    FROM Softver s LEFT OUTER JOIN Igra i
                                    ON s.IDSoftwer = i.IDSoftwer";
                kon.Open();

                using (SqlDataReader citaj = kom.ExecuteReader())
                {
                    while (citaj.Read())
                    {
                        if(citaj["Zanr"] != null){
                            Igra i = new Igra();
                            i.Id = (int)citaj["IDSoftwer"];
                            i.Naziv = citaj["Naziv"] as string;
                            i.GodinaIzdanja = (int)citaj["GodinaIzdanja"];
                            i.Cena = citaj["Cena"] as decimal?;
                            i.Zanr = citaj["Zanr"] as string;
                            this.listaSoftwer.Add(i);
                        }
                        else
                        {
                            Softwer s = new Softwer();
                            s.Id = (int)citaj["IDSoftwer"];
                            s.Naziv = citaj["Naziv"] as string;
                            s.GodinaIzdanja = (int)citaj["GodinaIzdanja"];
                            s.Cena = citaj["Cena"] as decimal?;
                            this.listaSoftwer.Add(s);
                        }
                    }
                }
            }
        }
        public void Dodaj(Softwer s){
            using (SqlConnection kon = new SqlConnection(strKon))
            {
                SqlCommand kom = kon.CreateCommand();
                kom.CommandText = @"INSERT INTO Softver(Naziv, GodinaIzdanja) VALUES(@naziv, @GodinaIzdanja)";
                kom.Parameters.Add(new SqlParameter("Naziv", s.Naziv));
                kom.Parameters.Add(new SqlParameter("GodinaIzdanja", s.GodinaIzdanja));

                kon.Open();

                this.listaSoftwer.Add(s);
                kom.ExecuteNonQuery();
            }
        }
    }
}
