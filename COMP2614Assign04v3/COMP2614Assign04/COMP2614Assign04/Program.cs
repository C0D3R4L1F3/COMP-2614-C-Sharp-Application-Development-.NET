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
    /// Class runs the methods if valid args are passed
    /// </summary>
    class Program
    {
        private const int COUNT_START = 1;
        private const int NULL_CUSTOMERS = 0;
        private const int NULL_PROVINCES = 0;
        private string filterByProvince;
        private CustomerCollection provinces;
        private CustomerCollection customers;

        /// <summary>
        /// Drives the program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Program start = new Program();
            start.run();
        }

        /// <summary>
        /// Runs the method for populateCustomers
        /// </summary>
        private void run()
        {
            populateSelectionList();
            populateCustomers();
        }

        /// <summary>
        /// Method to populate province selection list
        /// </summary>
        private void populateSelectionList()
        {
            try
            {
                provinces = new CustomerRepository().GetProvince();

                Console.WriteLine("Select province filter:");

                if (provinces != null && provinces.Count() > NULL_PROVINCES)
                {
                    int count = COUNT_START;

                    foreach (Customer selectionList in provinces)
                    {
                        Console.WriteLine("{0,11} {1,2}", count++ + ":", selectionList.Province);
                    }
                    Console.WriteLine("{0,15}", count + ": ALL");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Data Access Error\n\n{0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Processing Error\n\n{0}", ex.Message);
            }
        }

        /// <summary>
        /// Method to populates the customers list
        /// </summary>
        private void populateCustomers()
        {
            try
            {
                filterByProvince = Console.ReadLine();
                customers = CustomerRepository.GetCustomers();

                if (customers != null && customers.Count() > NULL_CUSTOMERS)
                {
                    if (filterByProvince.Equals("1"))
                    {
                        ConsolePrinter.Print(customers, "AB");
                    }
                    else if (filterByProvince.Equals("2"))
                    {
                        ConsolePrinter.Print(customers, "BC");
                    }
                    else if (filterByProvince.Equals("3"))
                    {
                        ConsolePrinter.Print(customers, "ON");
                    }
                    else if (filterByProvince.Equals("4"))
                    {
                        ConsolePrinter.Print(customers, "SK");
                    }
                    else if (filterByProvince.Equals("5"))
                    {
                        ConsolePrinter.Print(customers, "ALL");
                    }
                    else
                    {
                        Console.WriteLine("Error please pick a number between 1 to {0}", provinces.Count + COUNT_START);
                    }
                }
                else
                {
                    Console.WriteLine("No customers to print");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Data Access Error\n\n{0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Processing Error\n\n{0}", ex.Message);
            }
        }
    }
}