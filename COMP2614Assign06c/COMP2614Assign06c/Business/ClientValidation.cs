using COMP2614Assign06c.Common;
using COMP2614Assign06c.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06c.Business
{
    /// <summary>
    /// Class that validates a client
    /// </summary>
    class ClientValidation
    {
        private static List<string> errors;

        /// <summary>
        /// Creating new error list object
        /// </summary>
        static ClientValidation()
        {
            errors = new List<string>();
        }

        /// <summary>
        /// Returns the ErrorMessage
        /// </summary>
        public static string ErrorMessage => errors.Aggregate((i, j) => i + "\r\n" + j).ToString();

        // or ...
        //public static string ErrorMessage
        //{
        //    get
        //    {
        //        string message = "";

        //        foreach (string line in errors)
        //        {
        //            message += line + "\r\n";
        //        }

        //        return message;
        //    }
        //}

        /// <summary>
        /// Method to get the clients from ClientRepository
        /// </summary>
        /// <returns>clients</returns>
        public static ClientCollection GetClients() => ClientRepository.GetClients();

        /// <summary>
        /// Validating insertion of new Client record. Using internal method Validate
        /// </summary>
        /// <param name="client">Client object to validate</param>
        /// <returns>Return -1 if validation is fault, otherwise return number of rows affected</returns>
        public static int AddClient(Client client)
        {
            if (validate(client))
            {
                return ClientRepository.AddClient(client);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Validating update of Client record. Using internal method Validate
        /// </summary>
        /// <param name="client">Client object to validate</param>
        /// <returns>Return -1 if validation is fault, otherwise return number of rows affected</returns>
        public static int UpdateClient(Client client)
        {
            if (validate(client))
            {
                return ClientRepository.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Validating delete of Client record. Using internal method Validate
        /// </summary>
        /// <param name="client">Client object to validate</param>
        /// <returns>Return -1 if validation is fault, otherwise return number of rows affected</returns>
        public static int DeleteClient(Client client) => ClientRepository.DeleteClient(client);
        //{
        //    return ClientRepository.DeleteClient(client);
        //}

        /// <summary>
        /// Method for Client object validation
        /// </summary>
        /// <param name="client">Client object to validate</param>
        /// <returns>Returns True if validation is passed, otherwise returns False</returns>
        private static bool validate(Client client)
        {
            bool success = true;
            errors.Clear();

            if (string.IsNullOrWhiteSpace(client.CompanyName))
            {
                errors.Add("Company Name cannot be empty");
                success = false;
            }

            if (string.IsNullOrWhiteSpace(client.Address1))
            {
                errors.Add("Address1 cannot be empty");
                success = false;
            }

            if (string.IsNullOrWhiteSpace(client.Province))
            {
                errors.Add("Province cannot be empty");
                success = false;
            }

            if (client.YTDSales < 0)
            {
                errors.Add("YTDSales cannot be negative");
                success = false;
            }

            return success;
        }
    }
}