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
        [Range(0, 9999999999999999)]
        public decimal? Price { get; set; }

        [Display(Name = "Giá khuyến mại")]
        public decimal? PromotionPrice { get; set; }

        [Display(Name = "Đã bao gồm VAT")]
        public bool IncludeVAT { get; set; }

        [Display(Name = "Số lượng")]
        public int? Quantity { get; set; }

        [Display(Name = "Nhóm sản phẩm")]
        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Chi tiết")]
        public string Detail { get; set; }

        [Display(Name = "Thời gian bảo hành")]
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

        [Display(Name = "Tình trạng")]
        public bool Status { get; set; }

        [Display(Name = "Là sản phẩm Hot  (số ngày)")]
        public DateTime? TopHot { get; set; }
    }
}
