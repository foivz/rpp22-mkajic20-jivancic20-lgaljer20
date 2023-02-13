using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class InventoryRecordItemService
    {
        private InventoryRecordItemRepository repo = new InventoryRecordItemRepository();
        public List<InventoryRecordItem> GetRecordById(int id)
        {
            return repo.GetRecordById(id);
        }

        public List<Product> GetProductsFromId(int id)
        {
            return repo.GetProductsFromId(id);
        }

        public void AddRecord(InventoryRecordItem record)
        {
            repo.Add(record);
        }
    }
}
