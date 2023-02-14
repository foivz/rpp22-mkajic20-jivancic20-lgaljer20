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
    public class ProductRepository : IDisposable
    {
        private readonly SqlConnection connection;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DataBaseModel"].ConnectionString;

        public ProductRepository()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public List<Product> GetProducts()
        {

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

        public void CreateProduct(Product product)
        {
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

        public void UpdateProduct(Product product)
        {
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

        public void DeleteProduct(int id)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[ReceiptItem] WHERE ProductId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[DocketItem] WHERE ProductId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[InventoryRecordItem] WHERE ProductId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[OrderItem] WHERE ProductId = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Product] WHERE Id = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }

        }
        public Product GetProductById(int id)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Product] WHERE Id = @Id", connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Product product = new Product();

                    while (reader.Read())
                    {
                        product.Id = reader.GetInt32(0);
                        product.Price = reader.GetDouble(1);
                        product.Name = reader.GetString(2);
                        product.Amount = reader.GetInt32(3);
                        product.Minimum = reader.GetInt32(4);
                        product.Optimal = reader.GetInt32(5);
                        product.MeasurementUnit = reader.GetString(6);
                        product.UserId = reader.GetInt32(7);
                    }

                    return product;
                }
            }

        }

        public Product GetProductByName(string v)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Product] WHERE Name = @Name", connection))
            {
                command.Parameters.AddWithValue("@Name", v);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Product product = new Product();

                    while (reader.Read())
                    {
                        product.Id = reader.GetInt32(0);
                        product.Price = reader.GetDouble(1);
                        product.Name = reader.GetString(2);
                        product.Amount = reader.GetInt32(3);
                        product.Minimum = reader.GetInt32(4);
                        product.Optimal = reader.GetInt32(5);
                        product.MeasurementUnit = reader.GetString(6);
                        product.UserId = reader.GetInt32(7);
                    }

                    return product;
                }
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
