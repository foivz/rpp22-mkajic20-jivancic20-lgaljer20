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
                context.ReceiptItems.RemoveRange(context.ReceiptItems.Where(ri => ri.ReceiptId == receipt.Id));
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

        public List<ReceiptListItem> GetReceiptListItems(Receipt receipt)
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

        public List<ReceiptItem> GetReceiptItems(Receipt receipt) 
        {
            using (var context = new DataBaseModel())
            {
                context.Receipts.Attach(receipt);
                return receipt.ReceiptItems.ToList();
            }
        }

        public Product GetProduct(ReceiptItem receiptItem)
        {
            using (var context = new DataBaseModel())
            {
                context.ReceiptItems.Attach(receiptItem);
                return receiptItem.Product as Product;
            }
        }

        public int CreateReceipt(DateTime Date, double Price, double PDV, int UserId)
        {
            using (var context = new DataBaseModel())
            {
                var receipt = new Receipt
                {
                    Date = Date,
                    Price = Price,
                    PDV = PDV,
                    UserId = UserId
                };
                context.Receipts.Add(receipt);
                context.SaveChanges();

                return receipt.Id;
            }
        }

        public void CreateReceiptItem(ReceiptItem receiptItem)
        {
            using (var context = new DataBaseModel())
            {
                context.ReceiptItems.Add(receiptItem);
                context.SaveChanges();
            }
        }

        public Receipt GetReceipt(int Id)
        {
            using (var context = new DataBaseModel())
            {
                return context.Receipts.Where(r => r.Id == Id).FirstOrDefault();
            }
        }
    }
}
