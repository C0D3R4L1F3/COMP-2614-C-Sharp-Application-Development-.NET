using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Midterm
{
    /// <summary>
    /// Runs the methods if valid args are passed
    /// </summary>
    class Program
    {
        private const int CAPACITY = 4;

        /// <summary>
        /// Drives the program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            GroceryItemCollection items = new GroceryItemCollection(CAPACITY);

            items.Add(new GroceryItem("4L Milk", 3.87m, 2016, 10, 16));
            items.Add(new GroceryItem("500g Cottage Cheese", 4.28m, 2016, 11, 05));
            items.Add(new GroceryItem("1 Tin Mushroom Soup", 0.99m, 9999, 12, 31));
            items.Add(new GroceryItem("15kg Dog Food", 29.99m, 2018, 07, 23));

            ConsolePrinter.Print(items, "Natural Order:");

            items.Sort();

            ConsolePrinter.Print(items, "Sorted Order: [Price Descending]");
        }
    }
}