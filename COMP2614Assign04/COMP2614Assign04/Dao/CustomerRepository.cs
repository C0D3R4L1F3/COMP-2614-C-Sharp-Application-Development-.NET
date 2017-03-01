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
    class CustomertRepository
    {
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
        /// <param name="selection">the selection to set</param>
        /// <returns>the customers</returns>
        public static CustomerCollection GetCustomers(int selection)
        {
            CustomerCollection customers;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SelectionListCollection selectionList = new SelectionListCollection();
                string provinceFilter = selectionList.Provinces(selection);
                string query;

                if (provinceFilter.Equals("ALL"))
                {
                    query = @"SELECT CompanyName, Address, City, Province, PostalCode, CreditHold
                            FROM Customer
                            ORDER BY CompanyName";
                }
                else
                {
                    query = @"SELECT CompanyName, Address, City, Province, PostalCode, CreditHold
                            FROM Customer
                            WHERE Province = @province
                            ORDER BY CompanyName";
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@province", provinceFilter);

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

                            if (!reader.IsDBNull(1))
                            {
                                address = reader["Address"] as string;
                            }

                            if (!reader.IsDBNull(2))
                            {
                                city = reader["City"] as string;
                            }

                            if (!reader.IsDBNull(3))
                            {
                                province = reader["Province"] as string;
                            }

                            if (!reader.IsDBNull(4))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }

                            if (!reader.IsDBNull(5))
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
        public SelectionListCollection GetProvinces()
        {
            SelectionListCollection provinces;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;

                query = @"SELECT DISTINCT Province
                        FROM Customer";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    connection.Open();

                    provinces = new SelectionListCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string province = null;

                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                province = reader["Province"] as string;
                            }

                            provinces.Add(province);

                            province = null;
                        }

                        provinces.Add("ALL");
                        provinces.Add("EXIT");
                    }                    
                }
            }

            return provinces;
        }
    }
}