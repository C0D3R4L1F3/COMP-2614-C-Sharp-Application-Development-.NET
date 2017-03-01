using System;
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
        /// <param name="customers">the cutomers to print</param>
        /// <param name="provinceSelection">the province to select</param>
        public static void Print(CustomerCollection customers, string provinceSelection)
        {
            string divider = new string('-', 68);

            Console.WriteLine("Customer listing for {0}", provinceSelection);
            Console.WriteLine();
            Console.WriteLine($"{"CompanyName",-31} {"City",8} {"Prov",14} {"Postal",3}  {"Hold"}");
            Console.WriteLine(divider);

            foreach (Customer customer in customers)
            {
                if (IsValid(customer, provinceSelection))
                {
                    Console.WriteLine($"{customer.CompanyName,-35} {customer.City,-14} {customer.Province,-4} {customer.PostalCode,-7}  {customer.CreditHold}");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="province"></param>
        /// <returns></returns>
        public static bool IsValid(Customer customer, string province)
        {
            bool isValid = customer.Province.Equals("AB") && province.Equals("AB")
                || customer.Province.Equals("BC") && province.Equals("BC")
                || customer.Province.Equals("ON") && province.Equals("ON")
                || customer.Province.Equals("SK") && province.Equals("SK")
                || province.Equals("ALL");

            return isValid;
        }
    }
}