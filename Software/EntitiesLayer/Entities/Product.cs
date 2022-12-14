namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            DocketItems = new HashSet<DocketItem>();
            InventoryRecordItems = new HashSet<InventoryRecordItem>();
            OrderItems = new HashSet<OrderItem>();
            ReceiptItems = new HashSet<ReceiptItem>();
        }

        public int Id { get; set; }

        public double? Price { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Amount { get; set; }

        public int? Minimum { get; set; }

        public int? Optimal { get; set; }

        [StringLength(10)]
        public string MeasurementUnit { get; set; }

        public int UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocketItem> DocketItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryRecordItem> InventoryRecordItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptItem> ReceiptItems { get; set; }
    }
}
