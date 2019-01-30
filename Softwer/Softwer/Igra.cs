using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softwer
{
    public class Igra : Softwer
    {
        public string Zanr { get; set; }
        
        public override string ToString()
        {
            return base.ToString() + " " + this.Zanr;
        }
    }
}
