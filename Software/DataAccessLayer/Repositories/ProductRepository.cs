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
    public class ProductRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DataBaseModel"].ConnectionString;

        public ProductRepository()
        {
        }

        public List<Product> GetProducts()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Product]", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Product> products = new List<Product>();

                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                Id = reader.GetInt32(0),
                                Price = reader.GetDouble(1),
                                Name = reader.GetString(2),
                                Amount = reader.GetInt32(3),
                                Minimum = reader.GetInt32(4),
                                Optimal = reader.GetInt32(5),
                                MeasurementUnit = reader.GetString(6),
                                UserId = reader.GetInt32(7)
                            };
                            products.Add(product);
                        }

                        return products;
                    }
                }
            }
        }

    }
}
