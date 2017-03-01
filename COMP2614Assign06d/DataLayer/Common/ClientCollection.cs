using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Common
{
    /// <summary>
    /// Class to hold a collection of binding list of clients
    /// </summary>
    public class ClientCollection : BindingList<Client>
    {
        /// <summary>
        /// Returns and sets the TotalYTDSales
        /// </summary>
        public decimal TotalYTDSales => this.Sum(x => x.YTDSales);

        /// <summary>
        /// Returns and sets the CreditHoldCount
        /// </summary>
        public int CreditHoldCount => this.Count(x => x.CreditHold);

    }
}