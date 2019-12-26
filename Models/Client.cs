using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaHeinson.Models
{
    public class Client
    {
        [Key]
        public int id { set; get; }
        public string Name { set; get; }
        public string lastName { set; get; }
    }
}
