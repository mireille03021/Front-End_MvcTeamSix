namespace ANVI_Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductDestail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductDestail()
        {
            Images = new HashSet<Image>();
        }

        [Key]
        [StringLength(10)]
        public string PDID { get; set; }

        public int ProductID { get; set; }

        public int Stock { get; set; }

        public int SizeID { get; set; }

        public int ColorID { get; set; }

        public virtual Color Colors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }

        public virtual Product Products { get; set; }

        public virtual Size Sizes { get; set; }
    }
}
