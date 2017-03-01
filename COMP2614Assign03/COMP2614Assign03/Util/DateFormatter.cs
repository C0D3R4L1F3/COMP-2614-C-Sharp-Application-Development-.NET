using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>
    /// This class formats the date of invoice
    /// </summary>
    class DateFormatter
    {
        private DateTime dateTime;
        private string formatedDate;

        /// <summary>
        /// Method parses and formats the data for dates
        /// </summary>
        /// <param name="dateToFormat">the date to format </param>
        /// <returns>formatedDate</returns>
        public string Date(string dateToFormat)
        {
            formatedDate = dateToFormat;
            int year = int.Parse(formatedDate.Substring(0, 4));
            int month = int.Parse(formatedDate.Substring(5, 2));
            int day = int.Parse(formatedDate.Substring(8, 2));

            dateTime = new DateTime(year, month, day);
            formatedDate = dateTime.ToString("MMM dd, yyyy");

            return formatedDate;
        }

        /// <summary>
        /// Method to add days
        /// </summary>
        /// <param name="days">the days to add</param>
        /// <returns>formatedDate</returns>
        public string AddDays(int days)
        {
            dateTime = dateTime.AddDays(days);
            formatedDate = dateTime.ToString("MMM dd, yyyy");

            return formatedDate;
        }
    }
}