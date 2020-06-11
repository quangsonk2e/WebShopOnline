﻿namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        public long ProductID { get; set; }
        [Key]
        [Column(Order = 1)]
        public long OrderID { get; set; }
              
        public int? Quantity { get; set; }

        public decimal? Price { get; set; }
    }
}
