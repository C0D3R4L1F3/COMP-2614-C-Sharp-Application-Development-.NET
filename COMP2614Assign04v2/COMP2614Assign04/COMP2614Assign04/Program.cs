using System;
using System.Collections.Generic;
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
        private SelectionListCollection provinces;
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
        /// Runs the method for populateSelectionList and populateCustomers
        /// </summary>
        private void run()
        {
            populateSelectionList();
            populateCustomers();
        }

        /// <summary>
        /// Method to populateSelectionList of provinces
        /// </summary>
        private void populateSelectionList()
        {
            try
            {
                Console.WriteLine("Select province filter:");

                provinces = new CustomertRepository().GetProvinces();

                if (provinces != null && provinces.Count() > NULL_PROVINCES)
                {
                    int count = 1;
                    foreach (string provinceList in provinces)
                    {
                        Console.WriteLine($"{count,10}: {provinceList}");
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("No provinces to select");
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
        /// Method to populateCustomers list
        /// </summary>
        private void populateCustomers()
        {
            try
            {                
                string provinceFilter = Console.ReadLine();
                int selection;
                bool isNumber = int.TryParse(provinceFilter, out selection);
                customers = CustomertRepository.GetCustomers(selection);

                if (customers != null && customers.Count() > NULL_CUSTOMERS)
                {
                    if (selection > 0 && selection <= provinces.Count)
                    {
                        ConsolePrinter.Print(customers, selection);
                    }
                    else
                    {
                        Console.WriteLine("Error please pick a number between 1 to {0}", provinces.Count);
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