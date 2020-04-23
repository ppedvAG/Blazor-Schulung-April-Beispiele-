using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungApril.Data
{
    public class Aufgabe
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime ErledigtBis { get; set; }
        public bool Erledigt { get; set; }
        [NotMapped]
        public bool IsEdit { get; set; }
    }
}
