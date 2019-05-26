using Newtonsoft.Json;

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
        public int DSTID { get; set; }

        public int ProductID { get; set; }

        [Required]
        public string SubTitle { get; set; }

        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}
