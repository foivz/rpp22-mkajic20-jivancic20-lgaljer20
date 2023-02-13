using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    public class ReceiptListItem
    {
        public string Name { get; set; }
        public double? Price { get; set; }
        public int? Amount { get; set; }
    }
}
