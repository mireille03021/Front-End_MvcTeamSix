namespace ANVI_Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductDestails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductDestails()
        {
            Image = new HashSet<Image>();
        }

        [Key]
        [StringLength(10)]
        public string PDID { get; set; }

        public int ProductID { get; set; }

        public int Stock { get; set; }

        public int SizeID { get; set; }

        public int ColorID { get; set; }

        public virtual Colors Colors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Image { get; set; }

        public virtual Products Products { get; set; }

        public virtual Sizes Sizes { get; set; }
    }
}
