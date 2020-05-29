using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoomAspCore.Models
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            Places = new HashSet<Place>();
           // Place = new HashSet<Place>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        // Category & Products 
        public  virtual ICollection<Place> Places { get; set; }
    }
}
