using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GraphProductRepository
    {
        public List<Product> GetProductsGraph()
        {
            using (var context = new DataBaseModel())
            {
                try
                {
                    return context.Products.ToList();
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
