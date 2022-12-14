namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("OrderForm")]
    public partial class OrderForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderForm()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int UserId { get; set; }

        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
