namespace ANVI_Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int? ShippingID { get; set; }

        [Required]
        [StringLength(15)]
        public string RecipientName { get; set; }

        [Required]
        [StringLength(30)]
        public string RecipientAddressee { get; set; }

        [StringLength(10)]
        public string RecipientZipCod { get; set; }

        [Required]
        [StringLength(10)]
        public string RecipientCity { get; set; }

        [Required]
        [StringLength(20)]
        public string RecipientPhone { get; set; }

        [Required]
        [StringLength(15)]
        public string Payment { get; set; }

        public DateTime OrderDate { get; set; }

        [StringLength(50)]
        public string Remaeks { get; set; }

        public DateTime ShipDate { get; set; }

        public virtual Customer Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Shipper Shippers { get; set; }
    }
}
