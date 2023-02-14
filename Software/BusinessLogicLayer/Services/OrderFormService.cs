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
        public int CreateOrderForm(OrderForm orderForm)
        {
            return new OrderFormRepository().CreateOrderForm(orderForm);
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

        public bool ValidateData(OrderForm orderForm)
        {
            if (orderForm.Date < DateTime.Now)
            {
                return false;
            }

            if (orderForm.OrderItems.Count() < 1)
            {
                return false;
            }
            foreach(OrderItem item in orderForm.OrderItems)
            {
                if (item.Amount <= 0) return false;
            }

            return true;

        }
        //Luka Galjer
        public List<OrderForm> GetAllOrders() //orderForm
        {
            OrderFormRepository repo = new OrderFormRepository();
            return repo.GetAllOrders();
        }
    }
}

