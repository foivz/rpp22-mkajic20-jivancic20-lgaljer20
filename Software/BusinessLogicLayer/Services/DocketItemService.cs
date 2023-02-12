using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class DocketItemService
    {
        private DocketItemRepository repo = new DocketItemRepository();

        private ProductService productServis = new ProductService();
        public List<DocketItem> GetDocketsById(int id)
        {
            return repo.GetDocketsById(id);
        }

        public void AddDocketItem(DocketItem docketItem)
        {
            repo.AddDocketItem(docketItem);
           
            productServis.DodajProizvode(docketItem.ProductId, docketItem.Amount);

        }

        public int CheckIfProductExists(Docket docket, Product product)
        {
  
            return repo.CheckIfProductsExists(docket, product);
        }
        public void RemoveDocketItem(DocketItem docketItem)
        {
            repo.RemoveDocketItem(docketItem);
            productServis.OduzmiProizvode(docketItem.ProductId, docketItem.Amount);
        }
    }
}
