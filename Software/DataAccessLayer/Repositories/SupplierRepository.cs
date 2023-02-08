using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer.Repositories
{
    public class SupplierRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DataBaseModel"].ConnectionString;
        public SupplierRepository()
        {

        }

        public List<Supplier> GetSuppliers()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Supplier]", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Supplier> products = new List<Supplier>();

                        while (reader.Read())
                        {
                            Supplier product = new Supplier
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Address = reader.GetString(2),
                                Email = reader.GetString(3),
                                PhoneNumber = reader.GetString(4),

                            };
                            products.Add(product);
                        }

                        return products;
                    }
                }
            }
        }
        public Supplier GetSupplierById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Supplier] WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Supplier product = new Supplier();

                        while (reader.Read())
                        {
                            product.Id = reader.GetInt32(0);
                            product.Name = reader.GetString(1);
                            product.Address = reader.GetString(2);
                            product.Email = reader.GetString(3);
                            product.PhoneNumber = reader.GetString(4);
                        }

                        return product;
                    }
                }
            }
        }
    }
}
