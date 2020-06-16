namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Footer")]
    public partial class Footer
    {
        public int ID { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Nội dung")]
        public string Content { get; set; }
        [Display(Name = "Ẩn/Hiện")]
        public bool Status { get; set; }
    }
}
