namespace QuanLyCuaHang.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Imports = new HashSet<Import>();
            Receipts = new HashSet<Receipt>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string hoten { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(20)]
        public string tel { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }

        [StringLength(10)]
        public string gender { get; set; }

        [Required]
        [StringLength(20)]
        public string userRole { get; set; }

        [Required]
        [StringLength(100)]
        public string username { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [Column(TypeName = "image")]
        public byte[] avatar { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipts { get; set; }
    }
}
