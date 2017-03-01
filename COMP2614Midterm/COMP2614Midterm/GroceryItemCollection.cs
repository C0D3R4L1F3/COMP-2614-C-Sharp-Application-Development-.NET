using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Midterm
{
    /// <summary>
    /// This class represents a collection of GroceryItems
    /// </summary>
    class GroceryItemCollection : List<GroceryItem>
    {
        private decimal total;
        private const decimal PRE_TOTAL = 0.00m;

        /// <summary>
        /// Default constructor
        /// </summary>
        public GroceryItemCollection()
        {
        }

        /// <summary>
        /// Constructor to initialize a GroceryItemCollection object
        /// </summary>
        /// <param name="capacity">the capacity of the collection</param>
        public GroceryItemCollection(int capacity)
            : base(capacity)
        {
        }

        /// <summary>
        /// Returns the total
        /// </summary>
        public decimal Total
        {
            get
            {
                total = PRE_TOTAL;

                foreach (GroceryItem items in this)
                {
                    total += items.Price;
                }

                return total;
            }
        }
    }
}