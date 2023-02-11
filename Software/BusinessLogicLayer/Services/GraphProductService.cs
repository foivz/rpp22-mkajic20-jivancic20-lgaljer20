using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class GraphProductService
    {
        public List<Product> GetAllGraph()
        {
            GraphProductRepository repo = new GraphProductRepository();

            return repo.GetProductsGraph().ToList();
        }
    }
}
