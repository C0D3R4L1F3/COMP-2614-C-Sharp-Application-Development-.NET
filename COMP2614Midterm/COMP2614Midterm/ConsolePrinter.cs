using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Midterm
{
    /// <summary>
    /// This class is to output the GroceryItem list and total to console
    /// </summary>
    class ConsolePrinter
    {
        private const int SEPARATOR_LENGTH = 54;

        /// <summary>
        /// Prints the GroceryItems in predefined format
        /// </summary>
        /// <param name="items">the items to print</param>
        /// <param name="order">the order to print</param>
        public static void Print(GroceryItemCollection items, string order)
        {
            Console.WriteLine(order);
            Console.WriteLine("{0, -30} {1, 5}  {2, 6}", "Grocery Item", "Price", "Expires");
            Console.WriteLine(new string('-', SEPARATOR_LENGTH));

            foreach (GroceryItem item in items)
            {
                if (item.ExpirationDate == DateTime.MaxValue.Date)
                {
                    Console.WriteLine("{0, -30} {1, 5:F2}  {2, 6}", item.Description, item.Price, item.ExpirationDate.ToString("<Never>"));
                }
                else
                {
                    Console.WriteLine("{0, -30} {1, 5:F2}  {2, 6}", item.Description, item.Price, item.ExpirationDate.ToString("ddd MMM d, yyyy"));
                }
            }

            Console.WriteLine(new string('-', SEPARATOR_LENGTH));
            Console.WriteLine($"Total: {items.Total,29:F2}\n\n");
        }
    }
}