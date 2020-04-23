using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungApril.Data
{
    public class AufgabenVM
    {
        public AufgabenVM(TodoContext _db )
        {
            db = _db;
        }

      public TodoContext db { get; set; }
        public List<BlazorSchulungApril.Data.Aufgabe> Aufgaben { get; set; }
      public  void laden()
        {
            //Aufgaben = new List<Aufgabe>();
            Aufgaben = db.Aufgabe.ToList();

        }

        public void Add(Aufgabe a)
        {
            Aufgaben.Add(a);
            db.Aufgabe.Add(a);
            db.SaveChanges();
        }
        public void Update(Aufgabe a)
        {

            db.Aufgabe.Update(a);
            db.SaveChanges();
        }
    }
}
