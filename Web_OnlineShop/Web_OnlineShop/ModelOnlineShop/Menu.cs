﻿namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int ID { get; set; }

        [StringLength(250)]
        [Display(Name = "Tên")]
        public string Text { get; set; }

        [StringLength(250)]
        public string Link { get; set; }
        [Display(Name = "Thứ tự hiển thị")]
        public int? DisplayOrder { get; set; }

        [StringLength(50)]
        [Display(Name = "Đích")]
        public string Target { get; set; }
        [Display(Name = "Tình trạng (Ẩn/Hiện)")]
        public bool Status { get; set; }
        [Display(Name = "Loại menu")]
        public int? TypeID { get; set; }
    }
}
