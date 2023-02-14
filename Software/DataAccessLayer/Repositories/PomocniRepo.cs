using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PomocniRepo
    {
        public List<OrderForm> GetAllNarudzbenice()
        {
            using (var context = new DataBaseModel())
            {
                return context.OrderForms.ToList();
            }
        }
        public List<OrderItem> GetOrderStavkaId(int id)
        {
            using (var context = new DataBaseModel())
            {
                var query = from oi in context.OrderItems
                            where oi.OrderFormId == id
                            select oi;

                return query.ToList();
            }
        }
    }
}
