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

        public void Delete(Receipt receipt)
        {
            using (var context = new DataBaseModel())
            {
                context.Receipts.Attach(receipt);
                context.Receipts.Remove(receipt);
                context.SaveChanges();
            }
        }

        public string GetReceiptEmployee(Receipt receipt)
        {
            using (var context = new DataBaseModel())
            {
                context.Receipts.Attach(receipt);
                return receipt.User.Username;
            }
        }

        public List<ReceiptListItem> GetReceiptItems(Receipt receipt)
        {
            using (var context = new DataBaseModel())
            {
                List<ReceiptListItem> listItems = new List<ReceiptListItem>(); 
                context.Receipts.Attach(receipt);

                foreach(var i in receipt.ReceiptItems)
                {
                    listItems.Add(new ReceiptListItem
                    {
                        Name = i.Product.Name,
                        Price = i.Product.Price,
                        Amount = i.Amount
                    }) ;
                }

                return listItems;
            }
        }
    }
}
