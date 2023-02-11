using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class OrderFormService
    {
        public List<OrderForm> GetOrderForms()
        {
            return new OrderFormRepository().GetOrderForms();
        }
        public void CreateOrderForm(OrderForm orderForm)
        {
            new OrderFormRepository().CreateOrderForm(orderForm);
        }

        public void UpdateOrderForm(OrderForm orderForm)
        {
            new OrderFormRepository().UpdateOrderForm(orderForm);
        }

        public void DeleteOrderForm(int id)
        {
            new OrderFormRepository().DeleteOrderForm(id);
        }

        public OrderForm GetOrderFormById(int id)
        {
            return new OrderFormRepository().GetOrderFormById(id);
        }
    }
}

