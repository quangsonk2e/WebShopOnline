namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        [StringLength(50)]
        public string ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên")]
        public string Name { get; set; }
    }
}
