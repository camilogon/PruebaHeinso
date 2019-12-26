using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaHeinson.Models
{
    public class OrderDetail
    {
        [Key]
        public int idOrderDatails { set; get; }

        public int quantity { set; get; }

        [ForeignKey("Order")]
        public int idOrder { set; get; }

        [ForeignKey("Product")]
        public int idProduct { set; get; }
    }
}
