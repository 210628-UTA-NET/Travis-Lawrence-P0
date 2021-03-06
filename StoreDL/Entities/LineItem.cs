using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class LineItem
    {
        public int LineItemId { get; set; }
        public int? StoreFrontId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual StoreFront StoreFront { get; set; }
    }
}
