using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakti.Model
{
    public abstract class Kontakt
    {
        private int id;
        private int BrojTelefona;
        public abstract string DisplayName();


        public int BrojTelefona1
        {
            get { return BrojTelefona; }
            set { BrojTelefona = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        






    }
}
