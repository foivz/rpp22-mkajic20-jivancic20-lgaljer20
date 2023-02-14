using DataAccessLayer;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
   
    public class TestniService
    {
        private PomocniRepo repo = new PomocniRepo();

        public List<OrderForm> GetAllNarudzbenice() //orderForm
        {
            return repo.GetAllNarudzbenice();
        }

        public List<OrderItem> GetOrderItems(int id) //orderItem trebal bi oboje imat kod jana
        {
            return repo.GetOrderStavkaId(id);
        }
    }

   
}
