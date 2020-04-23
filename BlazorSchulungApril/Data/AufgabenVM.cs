using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungApril.Data
{
    public class AufgabenVM
    {
        public List<BlazorSchulungApril.Data.Aufgabe> Aufgaben { get; set; }
      public  void laden()
        {
            Aufgaben = new List<Aufgabe>();
        }

        public void Add(Aufgabe a)
        {
            Aufgaben.Add(a);
        }
    }
}
