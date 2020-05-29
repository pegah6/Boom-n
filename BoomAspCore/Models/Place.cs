using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoomAspCore.Models
{
    [Table("Place")]
    public partial class Place
    {
        public int ID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Images { get; set; }
        public string Description  { get; set; }

        public int CategoryID { get; set; }

        // Product & Category 
        public virtual Category Category { get; set; }
    }
}
