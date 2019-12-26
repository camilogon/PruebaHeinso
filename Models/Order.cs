using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaHeinson.Models
{
    public class Order
    {
        [Key]
        public int idOrder { set; get; }
        public DateTime date { get; set; } = DateTime.Today;
        [ForeignKey("Client")]
        public int idClient { set; get; }
    }
}
