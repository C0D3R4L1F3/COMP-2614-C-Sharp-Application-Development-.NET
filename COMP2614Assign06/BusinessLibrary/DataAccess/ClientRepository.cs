using BusinessLibrary.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.DataAccess
{
    /// <summary>
    /// Class for database interaction
    /// </summary>
    public class ClientRepository
    {
        private static string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                           Initial Catalog=assign06;
                                           User ID=student;
                                           Password=93nu5#S163;
                                           Encrypt=True;
                                           TrustServerCertificate=False;
                                           Connection Timeout=30;";

        /// <summary>
        /// Method for retrieving clients list from Database 
        /// </summary>
        /// <returns>the clients</returns>
        public static ClientCollection GetClients()
        {
            ClientCollection clients;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                               FROM Client973569
                               ORDER BY ClientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

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
                        decimal yTDSales;
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

                            yTDSales = (decimal)reader["YTDSales"];

                            creditHold = reader["CreditHold"] as bool? ?? false;

                            if (!reader.IsDBNull(9))
                            {
                                notes = reader["Notes"] as string;
                            }

                            clients.Add(new Client { ClientCode = clientCode
                                                     , CompanyName = companyName
                                                     , Address1 = address1
                                                     , Address2 = address2
                                                     , City = city
                                                     , Province = province
                                                     , PostalCode = postalCode
                                                     , YTDSales = yTDSales
                                                     , CreditHold = creditHold
                                                     , Notes = notes });

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

        /// <summary>
        /// Method for adding clients to the database
        /// </summary>
        /// <param name="client">the client to set</param>
        /// <returns>rowsAffected</returns>
        public static int AddClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"INSERT INTO Client973569
                               (ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)
                               Values (@clientCode, @companyName, @address1, @address2, @city, @province, @postalCode, @yTDSales, @creditHold, @notes)";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);

                    cmd.Parameters.AddWithValue("@address1", client.Address1);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@province", client.Province);

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@yTDSales", client.YTDSales);

                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Method for updating clients in the database
        /// </summary>
        /// <param name="client">the client to set</param>
        /// <returns>rowsAffected</returns>
        public static int UpdateClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"UPDATE Client973569
                               SET CompanyName = @companyName
                               , Address1 = @address1
                               , Address2 = @address2
                               , City = @city
                               , Province = @province
                               , PostalCode = @postalCode
                               , YTDSales = @yTDSales
                               , CreditHold = @creditHold
                               , Notes = @notes
                               WHERE ClientCode = @clientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    cmd.Parameters.AddWithValue("@companyName", client.CompanyName);

                    cmd.Parameters.AddWithValue("@address1", client.Address1);

                    if (client.Address2 != null)
                    {
                        cmd.Parameters.AddWithValue("@address2", client.Address2);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@address2", DBNull.Value);
                    }

                    if (client.City != null)
                    {
                        cmd.Parameters.AddWithValue("@city", client.City);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@city", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@province", client.Province);

                    if (client.PostalCode != null)
                    {
                        cmd.Parameters.AddWithValue("@postalCode", client.PostalCode);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@postalCode", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@yTDSales", client.YTDSales);

                    cmd.Parameters.AddWithValue("@creditHold", client.CreditHold);

                    if (client.Notes != null)
                    {
                        cmd.Parameters.AddWithValue("@notes", client.Notes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@notes", DBNull.Value);
                    }

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Method to delete a client from the database
        /// </summary>
        /// <param name="client">the client to set</param>
        /// <returns>rowsAffected</returns>
        public static int DeleteClient(Client client)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"DELETE Client973569
                               WHERE ClientCode = @clientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@clientCode", client.ClientCode);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        /// <summary>
        /// Method for retrieving province list from Database
        /// </summary>
        /// <returns>the provinces</returns>
        public static ProvinceCollection GetProvinces()
        {
            ProvinceCollection provinces;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query;

                query = @"SELECT ProvinceID, Abbreviation, Name
                        FROM Province
                        ORDER BY Abbreviation";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    connection.Open();

                    provinces = new ProvinceCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int provinceID;
                        string abbreviation;
                        string name = null;

                        while (reader.Read())
                        {
                            provinceID = (int)reader["ProvinceID"];

                            abbreviation = reader["Abbreviation"] as string;

                            if (!reader.IsDBNull(0))
                            {
                                name = reader["Name"] as string;
                            }

                            provinces.Add(new Provinces { ProvinceID = provinceID, Abbreviation = abbreviation, Name = name });

                            name = null;
                        }
                    }
                }
            }

            return provinces;
        }
    }
}