using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCsharp
{
    public class ProgramP
    {
        
        public static int ukid = 0;
        private int id;
        private string naziv;
        List<Element> element = new List<Element>();

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            private set
            {
                id = value;
            }
        }

        public List<Element> Element
        {
            get
            {
                return element;
            }

            private set
            {
                element = value;
            }
        }

        public ProgramP()
        {
            id = ukid++;
            naziv = naziv + id;
        }
        public ProgramP(string naziv)
        {
            id = ukid++;
            if (naziv == "")
            {
                this.naziv = "Program" + id;
            }
            else
            {
                this.naziv = naziv;
            }
        }
        public void PrevodPrograma()
        {
            for (int i = 0; i < element.Count; i++)
            {
                element[i].Prevod();
            }
        }
        public void DodajPaket(Element e)
        {
            element.Add(e);
        }
        public void Ukloni(int index)
        {
            element.RemoveAt(index);
        }
        public Element DohvatiPaket(int index)
        {
            return element.ElementAt(index);
        }
        public int UkupnoPaket()
        {
            return element.Count;
        }
    }
}