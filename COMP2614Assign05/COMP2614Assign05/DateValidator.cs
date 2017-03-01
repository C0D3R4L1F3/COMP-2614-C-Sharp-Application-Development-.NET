using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    /// <summary>
    /// Class that validates a date
    /// </summary>
    class DateValidator
    {
        private const int MINIMUM_YEAR = 1900;

        /// <summary>
        /// Method to validate a date that is greater than or 
        /// equal to the year 1900, month 1 and day 1
        /// </summary>
        /// <param name="year">the year to set</param>
        /// <param name="month">the month to set</param>
        /// <param name="day">the day to set</param>
        /// <returns>the isValidDate outcome</returns>
        public static bool Validate(string year, string month, string day)
        {
            bool isValidDate;

            try
            {
                DateTime date = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                isValidDate = int.Parse(year) >= MINIMUM_YEAR;
            }
            catch (Exception)
            {
                isValidDate = false;
            }

            return isValidDate;
        }
    }
}