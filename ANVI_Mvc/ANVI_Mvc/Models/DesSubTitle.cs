namespace ANVI_Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DesSubTitle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DSTID { get; set; }

        public int ProductID { get; set; }

        [Required]
        public string SubTitle { get; set; }

        public virtual Product Products { get; set; }
    }
}
