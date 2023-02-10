using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using EntitiesLayer.Entities;

namespace DataAccessLayer.Repositories
{
    //DataBaseModel
    public class OrderFormRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DataBaseModel"].ConnectionString;
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();

        public OrderFormRepository()
        {
        }

        public List<OrderForm> GetOrderForms()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[OrderForm]", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<OrderForm> products = new List<OrderForm>();

                        while (reader.Read())
                        {
                            OrderForm product = new OrderForm
                            {
                                Id = reader.GetInt32(0),
                                Date = reader.GetDateTime(1),
                                UserId = reader.GetInt32(2),
                                Supplier = _supplierRepository.GetSupplierById(reader.GetInt32(3))
                            };
                            products.Add(product);
                        }

                        return products;
                    }
                }
            }
        }

        public void CreateOrderForm(OrderForm product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO [dbo].[OrderForm] (Date, UserId, SupplierId) VALUES (@Date, @UserId, @SupplierId)", connection))
                {
                    command.Parameters.AddWithValue("@Date", product.Date);
                    command.Parameters.AddWithValue("@UserId", product.UserId);
                    command.Parameters.AddWithValue("@SupplierId", product.SupplierId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateOrderForm(OrderForm product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE [dbo].[OrderForm] SET Date = @Date, UserId = @UserId, SupplierId = @SupplierId WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@Date", product.Date);
                    command.Parameters.AddWithValue("@UserId", product.UserId);
                    command.Parameters.AddWithValue("@SupplierId", product.SupplierId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteOrderForm(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                
                using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[OrderItem] WHERE OrderFormId = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[OrderForm] WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public OrderForm GetOrderFormById(int id)
        {
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[OrderForm] WHERE Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            OrderForm product = new OrderForm();

                            while (reader.Read())
                            {
                                product.Id = reader.GetInt32(0);
                                product.Date = reader.GetDateTime(1);
                                product.UserId = reader.GetInt32(2);
                                product.Supplier = _supplierRepository.GetSupplierById(reader.GetInt32(3));
                            }

                            return product;
                        }
                    }
                }


            }
        }
    }
}

