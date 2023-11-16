namespace QuanLyCuaHang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptDetail")]
    public partial class ReceiptDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCTHD { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? Price { get; set; }
        public decimal? Discount { get; set; }
        public int? Count { get; set; }


        public virtual Product Product { get; set; }
    }
}
