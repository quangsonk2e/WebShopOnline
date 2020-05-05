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
        public string UserName { get; set; }

        [MaxLength(50)]
        public byte[] Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifieldDate { get; set; }

        [StringLength(50)]
        public string ModifieldBy { get; set; }
    }
}
