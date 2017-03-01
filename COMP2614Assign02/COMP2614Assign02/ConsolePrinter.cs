using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    /// <summary>
    /// Class to ouput contact list
    /// </summary>
    class ConsolePrinter
    {
        /// <summary>
        /// Method to print contacts as per Canada Post Standards
        /// </summary>
        /// <param name="contacts">Contact's to print</param>
        public static void Print(Contact contacts)
        {
            Console.WriteLine("{0} {1}", contacts.FirstName, contacts.LastName);
            Console.WriteLine("{0}", contacts.Address);
            Console.WriteLine("{0} {1}  {2}", contacts.City, contacts.Province, contacts.PostalCode);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}