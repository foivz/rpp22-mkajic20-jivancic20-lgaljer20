using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ReceiptRepository
    {
        public List<Receipt> GetReceipts()
        {
            using(var context = new DataBaseModel())
            {
                return context.Receipts.ToList();
            }
        }
    }
}
