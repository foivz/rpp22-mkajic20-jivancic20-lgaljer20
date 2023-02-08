using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBar.ViewModels
{
    public class UpravljanjeNarudzbenicamaVM
    {
        public DateTime? OrderDate { get; set; }

        public int UserId { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public User User { get; set; }

        public List<OrderItem> OrderItems { get; set; }
        public int OrderFormId { get; set; }

        public int ProductId { get; set; }

        public int? Amount { get; set; }

        public OrderForm OrderForm { get; set; }

        public Product Product { get; set; }
    }
}
