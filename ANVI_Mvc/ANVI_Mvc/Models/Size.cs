namespace ANVI_Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Size
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Size()
        {
            ProductDestails = new HashSet<ProductDetail>();
        }

        [Key]
        public int SizeID { get; set; }

        [Required]
        [StringLength(10)]
        public string SizeTitle { get; set; }

        [Required]
        [StringLength(10)]
        public string SizeContext { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetail> ProductDestails { get; set; }
    }
}
