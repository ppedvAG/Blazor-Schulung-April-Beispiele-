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
        [MaxLength(5,ErrorMessage ="nur Kürzel")]
        public string Hersteller { get; set; }
        public DateTime Jahr { get; set; }
    }
}
