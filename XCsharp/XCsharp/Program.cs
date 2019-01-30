using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCsharp
{
    class Program
    {
        public static string Unos()
        {
            Console.WriteLine("Unesite ime programa: ");
            string naziv = Console.ReadLine();
            return naziv;
        }
        static void Main(string[] args)
        {
            ProgramP pNaziv = new ProgramP(Unos());
            Console.WriteLine(pNaziv.Naziv);
            Paket model = new Paket();
            model.Naziv = "Model";
            Klasa student = new Klasa(PravoPristupa.javno, "Student");
            Klasa ispit = new Klasa(PravoPristupa.zasticeno, "Ispit");
            Paket view = new Paket();
            view.Naziv = "View";
            Paket studenti = new Paket();
            studenti.Naziv = "Studenti";
            Klasa upisStudenta = new Klasa(PravoPristupa.javno, "UpisStudenata");
            Klasa prijavaIspita = new Klasa(PravoPristupa.javno, "PrijavaIspita");
            Klasa glavniProzor = new Klasa();

            pNaziv.DodajPaket(model);
            model.DodajElement(student);
            model.DodajElement(ispit);
            pNaziv.DodajPaket(view);
            view.DodajElement(studenti);
            studenti.DodajElement(upisStudenta);
            studenti.DodajElement(prijavaIspita);
            pNaziv.DodajPaket(glavniProzor);

            pNaziv.PrevodPrograma();

        }
    }
}
