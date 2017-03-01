using COMP2614Assign06a.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06a.DataAccess
{
    /// <summary>
    /// Class for database interaction
    /// </summary>
    class ClientRepository
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
        /// <returns>the clients</returns>
        public static ClientCollection GetClients()
        {
            ClientCollection clients;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                            FROM Client
                            ORDER BY CompanyName";


                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    connection.Open();

                    clients = new ClientCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string clientCode;
                        string companyName;
                        string address1;
                        string address2 = null;
                        string city = null;
                        string province;
                        string postalCode = null;
                        decimal ytdSales;
                        bool creditHold;
                        string notes = null;

                        while (reader.Read())
                        {
                            clientCode = reader["ClientCode"] as string;

                            companyName = reader["CompanyName"] as string;

                            address1 = reader["Address1"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                address2 = reader["Address2"] as string;
                            }

                            if (!reader.IsDBNull(4))
                            {
                                city = reader["City"] as string;
                            }

                            province = reader["Province"] as string;

                            if (!reader.IsDBNull(6))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }

                            ytdSales = (decimal)reader["YTDSales"];

                            creditHold = reader["CreditHold"] as bool? ?? false;

                            if (!reader.IsDBNull(9))
                            {
                                notes = reader["Notes"] as string;
                            }

                            clients.Add(new Client(clientCode, companyName, address1, address2, city, province, postalCode, ytdSales, creditHold, notes));

                            address2 = null;
                            city = null;
                            postalCode = null;
                            notes = null;
                        }
                    }
                }

                return clients;
            }
        }
    }
}