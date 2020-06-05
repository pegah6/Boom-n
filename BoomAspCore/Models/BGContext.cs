using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoomAspCore.Models;

namespace BoomAspCore.Models
{
    public class BGContext : DbContext
    {
       public BGContext(DbContextOptions options) : base(options)
          {

          }
        public virtual DbSet<Category> Categorys { get; set; }


        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Product> Order { get; set; }
        public virtual DbSet<Product> OrderDetail { get; set; }
        public virtual DbSet<Product> Comment { get; set; }



    }
}
