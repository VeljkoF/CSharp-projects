using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCsharp
{
    public class Paket : Element
    {
        List<Element> elementi = new List<Element>();

        public void DodajElement(Element e)
        {
            elementi.Add(e);
        }
        

        public override void Prevod()
        {
            
            for (int i = 0; i < elementi.Count; i++)
            {
                elementi[i].Prevod();
            }
            
        }
    }
}