using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    /// <summary>
    /// Class to hold a Collection of SelectionList 
    /// </summary>
    class SelectionListCollection : List<string>
    {
        private const int ELEMENT = 1;

        /// <summary>
        /// Method to return a list of Provinces from the CustomerRepository
        /// </summary>
        /// <param name="index">the index to set</param>
        /// <returns>the provinces</returns>
        public string Provinces(int index)
        {
            CustomertRepository province = new CustomertRepository();
            string provinces = province.GetProvinces().ElementAt(index - ELEMENT);

            return provinces;
        }
    }
}