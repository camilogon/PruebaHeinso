using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaHeinson.Models;

namespace PruebaHeinson.Data
{
    public class PruebaHeinsonContext : DbContext
    {
        public PruebaHeinsonContext (DbContextOptions<PruebaHeinsonContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaHeinson.Models.Categoy> Categoy { get; set; }

        public DbSet<PruebaHeinson.Models.Client> Client { get; set; }

        public DbSet<PruebaHeinson.Models.Order> Order { get; set; }

        public DbSet<PruebaHeinson.Models.Product> Product { get; set; }

        public DbSet<PruebaHeinson.Models.OrderDetail> OrderDetail { get; set; }
    }
}
