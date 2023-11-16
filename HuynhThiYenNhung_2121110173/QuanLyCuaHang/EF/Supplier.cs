namespace QuanLyCuaHang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaNCC { get; set; }

        [StringLength(200)]
        public string TenNCC { get; set; }
    }
}
