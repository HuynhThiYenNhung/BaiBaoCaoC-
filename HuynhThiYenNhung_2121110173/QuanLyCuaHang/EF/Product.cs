namespace QuanLyCuaHang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Imports = new HashSet<Import>();
            ReceiptDetails = new HashSet<ReceiptDetail>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int quantity { get; set; }

        public double price { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int categoryId { get; set; }

        [Column(TypeName = "image")]
        public byte[] img { get; set; }

        //public decimal? Discount { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
