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
            List<ReceiptItem> receiptItems;
            receiptItems = repo.GetReceiptItems(receipt);

            ProductRepository productRepository = new ProductRepository();

            foreach(ReceiptItem receiptItem in receiptItems)
            {
                var product = repo.GetProduct(receiptItem);
                int newAmount = (int)(product.Amount + receiptItem.Amount);
                productRepository.UpdateAmount(product, newAmount);
            }
            repo.Delete(receipt);
        }

        public string GetReceiptUsername(Receipt receipt)
        {
            return repo.GetReceiptEmployee(receipt);
        }

        public List<ReceiptListItem> GetReceiptItems(Receipt receipt)
        {
            return repo.GetReceiptListItems(receipt);
        }

        public List<Product> GetAllProducts()
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.GetProducts();
        }
    }
}
