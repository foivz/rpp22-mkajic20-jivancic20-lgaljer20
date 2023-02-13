using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InventoryRecordRepository
    {

        public List<InventoryRecord> GetAllRecords()
        {
            using (var context = new DataBaseModel())
            {
                return context.InventoryRecords.ToList();
            }
        }

        public List<InventoryRecord> GetRecordById(int id)
        {
            using (var context = new DataBaseModel())
            {
                var query = from r in context.InventoryRecords
                            where r.Id == id
                            select r;

                return query.ToList();
            }
        }

        public void Add(InventoryRecord record)
        {
            using (var context = new DataBaseModel())
            {
               
                context.InventoryRecords.Attach(record);
                context.InventoryRecords.Add(record);
                context.SaveChanges();
            }
        }


    }
}
