namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserGroup")]
    public partial class UserGroup
    {
        [StringLength(20)]
        public string ID { get; set; }

        [StringLength(50)]
        [Display(Name = "T�n nh�m")]
        public string Name { get; set; }
    }
}
