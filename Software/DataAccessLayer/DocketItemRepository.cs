using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DocketItemRepository
    {

        public List<DocketItem> GetDocketsById(int id)
        {
            using (var context = new DataBaseModel())
            {
                var query = from d in context.DocketItems.Include("Product")
                            where d.DocketId == id
                            select d;

                return query.ToList();
            }
        }
        public int CheckIfProductsExists(Docket docket, Product product)
        {
            using (var context = new DataBaseModel())
            {
                var query = from d in context.DocketItems
                           where d.DocketId == docket.Id &&  d.ProductId == product.Id
                            select d;

                return query.Count();
            }
        }

        public void AddDocketItem(DocketItem docketItem)
        {
            using (var context = new DataBaseModel())
            {
                context.DocketItems.Attach(docketItem);
                context.DocketItems.Add(docketItem);
                context.SaveChanges();
            }
        }
    }
}
