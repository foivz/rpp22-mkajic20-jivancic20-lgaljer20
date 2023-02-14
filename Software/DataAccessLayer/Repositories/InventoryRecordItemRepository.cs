using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InventoryRecordItemRepository
    {
        public List<InventoryRecordItem> GetRecordById(int id)
        {
            using (var context = new DataBaseModel())
            {
                var query = from r in context.InventoryRecordItems
                            where r.InventoryRecordId == id
                            select r;

                return query.ToList();
            }
        }

        public List<Product> GetProductsFromId(int id)
        {
            using (var context = new DataBaseModel())
            {
                var query = from i in context.InventoryRecordItems
                                 where i.InventoryRecordId == id
                                 select i.Product;

                return query.ToList();
            }
        }
        public void Add(InventoryRecordItem record)
        {
            using (var context = new DataBaseModel())
            {
                Console.WriteLine("ovo je test dodavanje itema");
                context.InventoryRecordItems.Attach(record);
                context.InventoryRecordItems.Add(record);
                context.SaveChanges();
            }
        }
    }
}
