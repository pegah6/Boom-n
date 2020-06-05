using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoomAspCore.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string  Description { get; set; }

        public int CategoryID { get; set; }

        // Product & Category 
        [ForeignKey("CategoryID")]
        public virtual  Category Category { get; set; }

        // Product & Comment
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
