using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCsharp
{
    public abstract class Element
    {
        private string naziv;

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
        public Element()
        {

        }
        public Element(string naziv)
        {
            this.naziv = naziv;
        }
        public abstract void Prevod();
    }
}