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
    public class InvoiceRepository
    {
        private static string connString = @"Server=tcp:comp2614.database.windows.net,1433;
                                            Initial Catalog=FinalExam;
                                            User ID=student;
                                            Password=93nu5#S163;
                                            Encrypt=True;
                                            TrustServerCertificate=False;
                                            Connection Timeout=30;";

        /// <summary>
        /// Method to get invoices from database
        /// </summary>
        /// <returns>invoices</returns>
        public static InvoiceCollection GetInvoices()
        {
            InvoiceCollection invoices;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT DetailId, Quantity, Sku, Description, Price, Taxable
                               FROM InvoiceDetail
                               ORDER BY DetailId";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    invoices = new InvoiceCollection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int detailId;
                        int quantity;
                        string sku;
                        string description = null;
                        decimal price;
                        bool taxable = false;

                        while (reader.Read())
                        {
                            detailId = (int)reader["DetailId"];
                            quantity = (int)reader["Quantity"];
                            sku = reader["Sku"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                description = reader["Description"] as string;
                            }

                            price = (decimal)reader["Price"];

                            if (!reader.IsDBNull(5))
                            {
                                taxable = (bool)reader["Taxable"];
                            }

                            invoices.Add(new Invoice { DetailId = detailId, Quantity = quantity, Sku = sku, Description = description, Price = price, Taxable = taxable });

                            description = null;
                            taxable = false;
                        }
                    }
                }

                return invoices;
            }
        }
    }
}