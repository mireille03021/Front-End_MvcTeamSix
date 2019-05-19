namespace ANVI_Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImgID { get; set; }

        [Required]
        [StringLength(10)]
        public string PDID { get; set; }

        [Required]
        [StringLength(50)]
        public string ImgName { get; set; }

        public virtual ProductDetail ProductDestails { get; set; }
    }
}
