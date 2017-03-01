using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class DateValidator
    {
        public static bool Validate(string year, string month, string day)
        {
            DateTime minimumDate = new DateTime(1900, 1, 1);
            DateTime date;
            string dateFormat = String.Format("{0}-{1}-{2}", year, month, day);

            if (DateTime.TryParseExact(dateFormat, "yyyy-M-d", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out date) && date >= minimumDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
