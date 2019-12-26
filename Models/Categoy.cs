using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaHeinson.Models
{
    public class Categoy
    {
        [Key]
        public int idCategoiry { set; get; }
        public string name { set; get; }
        public string description { set; get; }
    }
}
