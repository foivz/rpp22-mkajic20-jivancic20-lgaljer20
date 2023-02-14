using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public static class CreateReceiptService
    {
        public static List<AddReceiptItem> items = new List<AddReceiptItem>();
        public static void AddReceiptItem(Product product, int amount)
        {
            AddReceiptItem item = new AddReceiptItem();
            item.amount = amount;
            item.product = product;
            items.Add(item);
        }

        public static List<AddReceiptItem> GetAddedItems()
        {
            return items;
        }

        public static float GetTotalPrice()
        {
            float price = 0;
            foreach (var item in items)
            {
                price += (float)item.product.Price * item.amount;
            }
            return price;
        }

        public static void RemoveItem(AddReceiptItem item)
        {
            items.Remove(item);
        }
    }
}
