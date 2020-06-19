namespace Web_OnlineShop.ModelOnlineShop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên người sử dụng")]
        public string UserName { get; set; }

        [StringLength(250)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [StringLength(20)]
        [Display(Name = "Thuộc nhóm")]
        public string GroupID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên")]
        public string Name { get; set; }

        [StringLength(250)]
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Vùng")]
        public int? ProvinceID { get; set; }
        [Display(Name = "Huyện")]
        public int? DistricID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifieldDate { get; set; }

        [StringLength(50)]
        public string ModifieldBy { get; set; }
        [Display(Name = "Tình trạng")]
        public bool Status { get; set; }
    }
}
