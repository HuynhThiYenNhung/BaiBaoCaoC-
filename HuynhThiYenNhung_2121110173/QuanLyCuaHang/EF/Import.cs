namespace QuanLyCuaHang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Import")]
    public partial class Import
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public DateTime? NgayNhap { get; set; }

        public int MaNCC { get; set; }

        public virtual Product Product { get; set; }

        public virtual User User { get; set; }
    }
}
