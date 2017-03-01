using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Common
{
    /// <summary>
    /// Class to hold a collection of binding list of clients
    /// </summary>
    public class ClientCollection : BindingList<Client>
    {
        /// <summary>
        /// Returns the ClientCount
        /// </summary>
        public int ClientCount => this.Count;

        /// <summary>
        /// Returns the CreditHoldCount
        /// </summary>
        public int CreditHoldCount => this.Count(x => x.CreditHold);

        /// <summary>
        /// Returns the TotalYTDSales
        /// </summary>
        public decimal TotalYTDSales => this.Sum(x => x.YTDSales);
    }
}