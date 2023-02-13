using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class OrderItemService
    {
        public List<OrderItem> GetOrderItems()
        {
            using (OrderItemRepository orderItemRepository = new OrderItemRepository())
            {
                return orderItemRepository.GetOrderItems();
            }
        }
        public List<OrderItem> GetOrderItemsById(int id)
        {
            using (OrderItemRepository orderItemRepository = new OrderItemRepository())
            {
                return orderItemRepository.GetOrderItemsById(id);
            }
        }
        public OrderItem GetOrderItemById(int id)
        {
            using (OrderItemRepository orderItemRepository = new OrderItemRepository())
            {
                return orderItemRepository.GetOrderItemById(id);
            }
        }
    }
}
