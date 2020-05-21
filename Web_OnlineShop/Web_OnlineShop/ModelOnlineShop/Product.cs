namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }

        [StringLength(250)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }

        [StringLength(10)]
        [Display(Name = "mã sản phẩm")]
        public string Code { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [StringLength(250)]
        [Display(Name = "Ảnh")]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }

        [Display(Name = "Giá")]
        public decimal? Price { get; set; }
        [Display(Name = "Giá khuyến mại")]
        public decimal? PromotionPrice { get; set; }

        public bool IncludeVAT { get; set; }

        public int? Quantity { get; set; }

        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public int? Warranty { get; set; }
       
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        
        public DateTime? ModifieldDate { get; set; }

        [StringLength(50)]
        public string ModifieldBy { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]        
        public string MetaDescriptions { get; set; }

        
        public bool Status { get; set; }

        public DateTime? TopHot { get; set; }
    }
}
