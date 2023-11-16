namespace QuanLyCuaHang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        public int UserId { get; set; }

        public DateTime? NgayBan { get; set; }

        public virtual User User { get; set; }
    }
}
