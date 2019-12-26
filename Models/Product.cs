using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaHeinson.Models
{
    public class Product
    {
        [Key]
        public int idProduct { set; get; }
        public string name { set; get; }
        public string description { set; get; }
        public int price { get; set; }
        [ForeignKey("Product")]
        public int idCategory { set; get; }
    }
}
