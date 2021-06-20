namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAccount")]
    public partial class UserAccount
    {
        [StringLength(50)]
        [Display(Name = "Mã Tài Khoản")]
        public string ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên Tài Khoản")]
        public string UserName { get; set; }

        [StringLength(50)]
        [Display(Name = "Mật Khẩu")]
        public string PassWord { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Trạng Thái")]
        public string Status { get; set; }
    }
}
