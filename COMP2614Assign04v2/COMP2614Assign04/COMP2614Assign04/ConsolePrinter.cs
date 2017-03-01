﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    /// <summary>
    /// Class to output the customer list
    /// </summary>
    class ConsolePrinter
    {
        /// <summary>
        /// Method to print customers in predefined text
        /// </summary>
        /// <param name="customers">the customers to print</param>
        /// <param name="selection">the selection to print</param>
        public static void Print(CustomerCollection customers, int selection)
        {
            string divider = new string('-', 68);
            SelectionListCollection provinces = new SelectionListCollection();

            Console.WriteLine($"Customer listing for {provinces.Provinces(selection)}");
            Console.WriteLine();
            Console.WriteLine($"{"CompanyName",-31} {"City",8} {"Prov",14} {"Postal",3}  {"Hold"}");
            Console.WriteLine(divider);

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.CompanyName,-35} {customer.City,-14} {customer.Province,-4} {customer.PostalCode,-7}  {customer.CreditHold}");
            }
        }
    }
}