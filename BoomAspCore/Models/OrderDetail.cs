using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BoomAspCore.Models
{
    public class OrderDetail
    {
            public int ID { get; set; }
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public int quantity { get; set; }

            [ForeignKey("OrderId")]
            public virtual Order Order { get; set; }
            [ForeignKey("ProductId")]
            public virtual Product Product { get; set; }
        
    }
}
