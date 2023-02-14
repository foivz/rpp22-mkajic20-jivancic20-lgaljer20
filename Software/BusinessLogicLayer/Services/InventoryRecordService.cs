using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class InventoryRecordService
    {
       private InventoryRecordRepository repo = new InventoryRecordRepository();
        public List<InventoryRecord> GetAllRecords()
        {
           return repo.GetAllRecords().ToList();
        }

      public List<InventoryRecord> GetRecordById(int id)
        {
           return repo.GetRecordById(id);
        }

        public void AddRecord(InventoryRecord record)
        {
            repo.Add(record);
        }
    }
}
