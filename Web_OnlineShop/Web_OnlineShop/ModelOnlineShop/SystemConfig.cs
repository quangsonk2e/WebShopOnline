namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemConfig")]
    public partial class SystemConfig
    {
        public long ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Kiểu")]
        public string Type { get; set; }

        [StringLength(250)]
        [Display(Name = "Giá trị")]
        public string Value { get; set; }
        [Display(Name = "Tình trạng")]
        public bool Status { get; set; }
    }
}
