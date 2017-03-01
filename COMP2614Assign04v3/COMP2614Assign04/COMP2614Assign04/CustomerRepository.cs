using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    /// <summary>
    /// Class for database interaction
    /// </summary>
    class CustomerRepository
    {
        private const int FIRST_INDEX = 0;
        private const int SECOND_INDEX = 1;
        private const int THIRD_INDEX = 2;
        private const int FOURTH_INDEX = 3;
        private const int FIFTH_INDEX = 4;
        private const int SIXTH_INDEX = 5;
        private static string connectionString = @"Server=tcp:comp2614.database.windows.net,1433;
                                                   Initial Catalog=week06;
                                                   User ID=student;
                                                   Password=93nu5#S163;
                                                   Encrypt=True;
                                                   TrustServerCertificate=False;
                                                   Connection Timeout=30;";

        /// <summary>
        /// Method for retrieving customers list from Database
        /// </summary>
        /// <returns>the customers</returns>
        public static CustomerCollection GetCustomers()
        {
            CustomerCollection customers;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT CompanyName, Address, City, Province, PostalCode, CreditHold
                             FROM Customer
                             ORDER BY CompanyName";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    connection.Open();

                    customers = new CustomerCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string companyName;
                        string address = null;
                        string city = null;
                        string province = null;
                        string postalCode = null;
                        bool creditHold = false;

                        while (reader.Read())
                        {
                            companyName = reader["CompanyName"] as string;

                            if (!reader.IsDBNull(SECOND_INDEX))
                            {
                                address = reader["Address"] as string;
                            }

                            if (!reader.IsDBNull(THIRD_INDEX))
                            {
                                city = reader["City"] as string;
                            }

                            if (!reader.IsDBNull(FOURTH_INDEX))
                            {
                                province = reader["Province"] as string;
                            }

                            if (!reader.IsDBNull(FIFTH_INDEX))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }

                            if (!reader.IsDBNull(SIXTH_INDEX))
                            {
                                creditHold = reader["CreditHold"] as bool? ?? false;
                            }

                            customers.Add(new Customer(companyName, address, city, province, postalCode, creditHold));

                            address = null;
                            city = null;
                            province = null;
                            postalCode = null;
                            creditHold = false;
                        }
                    }
                }

                return customers;
            }
        }

        /// <summary>
        /// Method for retrieving province list from Database
        /// </summary>
        /// <returns>the provinces</returns>
        public CustomerCollection GetProvince()
        {
            CustomerCollection provinces;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT DISTINCT Province
                             FROM Customer";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    connection.Open();

                    provinces = new CustomerCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string province = null;

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(FIRST_INDEX))
                            {
                                province = reader["Province"] as string;
                            }

                            provinces.Add(new Customer(province));

                            province = null;
                        }
                    }
                }

                return provinces;
            }
        }
    }
}