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
        public DbSet<BoomAspCore.Models.Place> Place { get; set; }
        
    }
}
