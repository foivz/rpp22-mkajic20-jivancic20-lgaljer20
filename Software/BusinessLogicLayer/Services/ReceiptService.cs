using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ReceiptService
    {
        public ReceiptRepository repo { get; set; }
        public ReceiptService()
        {
            repo = new ReceiptRepository();
        }
        public List<Receipt> GetAllReceipts()
        {
            return repo.GetReceipts();
        }

        public void DeleteReceipt(Receipt receipt)
        {
            repo.Delete(receipt);
        }
    }
}
