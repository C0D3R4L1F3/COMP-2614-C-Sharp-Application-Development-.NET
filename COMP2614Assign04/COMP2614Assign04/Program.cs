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
        private const int ELEMENT = 1;
        private const int COUNT_START = 1;
        private const int EXIT_CODE = 0;
        private const int SELECTION_START = 0;
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
        /// Runs the method for populateCustomers
        /// </summary>
        private void run()
        {
            populateCustomers();
        }

        /// <summary>
        /// Method to populateSelectionList of provinces
        /// </summary>
        private void populateSelectionList()
        {
            Console.WriteLine("Select province filter:");

            provinces = new CustomertRepository().GetProvinces();

            if (provinces != null && provinces.Count() > NULL_PROVINCES)
            {
                int count = COUNT_START;
                foreach (string selectionList in provinces)
                {
                    Console.WriteLine($"{count,10}: {selectionList}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("No provinces to select");
                Environment.Exit(EXIT_CODE);
            }
        }

        /// <summary>
        /// Method to populateCustomers list through populateSelectionList method
        /// </summary>
        private void populateCustomers()
        {
            int selection = SELECTION_START;

            do
            {
                try
                {
                    populateSelectionList();

                    string provinceFilter = Console.ReadLine();
                    bool isNumber = int.TryParse(provinceFilter, out selection);
                    customers = CustomertRepository.GetCustomers(selection);

                    if (selection > 0 && selection <= provinces.Count - ELEMENT)
                    {
                        if (customers != null && customers.Count() > NULL_CUSTOMERS)
                        {
                            ConsolePrinter.Print(customers, selection);
                        }
                        else
                        {
                            Console.WriteLine("No customers to print");
                            Environment.Exit(EXIT_CODE);
                        }
                    }
                    else if (selection == provinces.Count)
                    {
                        Console.WriteLine("COMP2614Assign04 will now exit . . .");
                        Environment.Exit(EXIT_CODE);
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Data Access Error\n\n{0}", ex.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("**********INVALID SELECTION**********\nPlease select a number between 1 to {0}\n\n", provinces.Count);
                }
            } while (selection >= SELECTION_START);
        }
    }
}