using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Midterm
{
    /// <summary>
    /// This class represents a GroceryItem and compares them by price descending
    /// </summary>
    class GroceryItem : IComparable<GroceryItem>
    {
        private const int GREATER_OBJECT = 1;

        /// <summary>
        /// Constructor to initialize a GroceryItem object
        /// </summary>
        /// <param name="description">the description given for GroceryItem</param>
        /// <param name="price">the price given for GroceryItem</param>
        /// <param name="year">the expiration year given for GroceryItem</param>
        /// <param name="month">the expiration month given for GroceryItem</param>
        /// <param name="day">the expiration day given for GroceryItem</param>
        public GroceryItem(string description, decimal price, int year, int month, int day)
        {
            this.Description = description;
            this.Price = price;
            this.ExpirationDate = new DateTime(year, month, day);
        }

        /// <summary>
        /// Returns the Description
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Returns and sets the Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Returns the ExpirationDate
        /// </summary>
        public DateTime ExpirationDate { get; }

        /// <summary>
        /// Returns the GREATER_OBJECT
        /// </summary>
        /// <param name="other">other object to compare</param>
        /// <returns>descending order of prices</returns>
        public int CompareTo(GroceryItem other)
        {
            if (other == null)
            {
                return GREATER_OBJECT;
            }

            return other.Price.CompareTo(this.Price);
        }
    }
}