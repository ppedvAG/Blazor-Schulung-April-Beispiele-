using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulungApril.Data
{
    public class Car
    {
        public int ID { get; set; }
        [Range(42,450,ErrorMessage ="PS Range beachten")]
        public int Leistung { get; set; }
        [Required(ErrorMessage ="da muss name rein")]
        public string Hersteller { get; set; }
    }
}
