using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class OrderItemRepository : IDisposable
    {
        private readonly SqlConnection connection;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DataBaseModel"].ConnectionString;
        public OrderItemRepository()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void CreateOrderItems(List<OrderItem> orderItems)
        {
            foreach (var item in orderItems)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO [dbo].[OrderItem] (OrderFormId, ProductId, Amount) VALUES (@OrderFormId, @ProductId, @Amount)", connection))
                {
                    command.Parameters.AddWithValue("@OrderFormId", item.OrderFormId);
                    command.Parameters.AddWithValue("@ProductId", item.ProductId);
                    command.Parameters.AddWithValue("@Amount", item.Amount);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<OrderItem> GetOrderItems()
        {

            using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[OrderItem]", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<OrderItem> products = new List<OrderItem>();

                    while (reader.Read())
                    {
                        OrderItem product = new OrderItem
                        {
                            OrderFormId = reader.GetInt32(0),
                            ProductId = reader.GetInt32(1),
                            Amount = reader.GetInt32(2)
                        };
                        products.Add(product);
                    }

                    return products;
                }
            }
        }
        public List<OrderItem> GetOrderItemsById(int id)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[OrderItem] WHERE OrderFormId = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<OrderItem> products = new List<OrderItem>();

                    while (reader.Read())
                    {
                        OrderItem product = new OrderItem();
                        product.OrderFormId = reader.GetInt32(0);
                        product.ProductId = reader.GetInt32(1);
                        product.Amount = reader.GetInt32(2);
                        products.Add(product);
                    }
                    return products;
                }
            }
        }

        public OrderItem GetOrderItemById(int id)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[OrderItem] WHERE OrderFormId = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    OrderItem product = new OrderItem();

                    while (reader.Read())
                    {
                        product.OrderFormId = reader.GetInt32(0);
                        product.ProductId = reader.GetInt32(1);
                        product.Amount = reader.GetInt32(2);
                    }
                    return product;
                }
            }
        }
        public void DeleteOrderItems(int orderFormId)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[OrderItem] WHERE OrderFormId = @orderFormId", connection))
            {
                command.Parameters.AddWithValue("@orderFormId", orderFormId);
                command.ExecuteNonQuery();
            }
        }
        public void Dispose()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }

            connection.Dispose();
        }

        
    }
}

