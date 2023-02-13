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

        public void CreateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Product] (Price, Name, Amount, Minimum, Optimal, MeasurementUnit, UserId) VALUES (@Price, @Name, @Amount, @Minimum, @Optimal, @MeasurementUnit, @UserId)", connection))
                {
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Amount", product.Amount);
                    command.Parameters.AddWithValue("@Minimum", product.Minimum);
                    command.Parameters.AddWithValue("@Optimal", product.Optimal);
                    command.Parameters.AddWithValue("@MeasurementUnit", product.MeasurementUnit);
                    command.Parameters.AddWithValue("@UserId", product.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE [dbo].[Product] SET Price = @Price, Name = @Name, Amount = @Amount, Minimum = @Minimum, Optimal = @Optimal, MeasurementUnit = @MeasurementUnit, UserId = @UserId WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Amount", product.Amount);
                    command.Parameters.AddWithValue("@Minimum", product.Minimum);
                    command.Parameters.AddWithValue("@Optimal", product.Optimal);
                    command.Parameters.AddWithValue("@MeasurementUnit", product.MeasurementUnit);
                    command.Parameters.AddWithValue("@UserId", product.UserId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Product] WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Autor: Mladen Kajić
        public void UpdateAmount(Product product, int amount)
        {
            using(var context = new DataBaseModel())
            {
                context.Products.Attach(product);
                product.Amount = amount;
                context.SaveChanges();
            }
        }
    }
}
