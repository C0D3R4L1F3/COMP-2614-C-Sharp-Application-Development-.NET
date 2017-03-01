using BusinessLibrary.Common;
using BusinessLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLibrary.Business
{
    /// <summary>
    /// Class that validates a client
    /// </summary>
    public class ClientValidation
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

        /// <summary>
        /// Method to get the clients from ClientRepository
        /// </summary>
        /// <returns>clients</returns>
        public static ClientCollection GetClients() => ClientRepository.GetClients();

        /// <summary>
        /// Method to get the provinces from ClientRepository
        /// </summary>
        /// <returns>provinces</returns>
        public static ProvinceCollection GetProvinces() => ClientRepository.GetProvinces();

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

        /// <summary>
        /// Method for Client object validation
        /// </summary>
        /// <param name="client">Client object to validate</param>
        /// <returns>Returns True if validation is passed, otherwise returns False</returns>
        private static bool validate(Client client)
        {
            bool result = true;
            errors.Clear();

            if (string.IsNullOrWhiteSpace(client.ClientCode))
            {
                errors.Add("Client Code cannot be empty");
                result = false;
            }
            else if (client.ClientCode.Length < 5)
            {
                errors.Add("Client Code must follow pattern: AAAAA");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(client.CompanyName))
            {
                errors.Add("Company Name cannot be empty");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(client.Address1))
            {
                errors.Add("Address1 cannot be empty");
                result = false;
            }

            //Validate proper Canadian province
            Regex regex = new Regex("^[ABMNOPQSY][BCEKLNSTU]*$");

            if (string.IsNullOrWhiteSpace(client.Province))
            {
                errors.Add("Province cannot be empty");
                result = false;
            }
            else if (client.Province.Length < 2 || client.Province.Length > 2 || client.Province == client.Province.ToLower())
            {
                errors.Add("Province must follow pattern: AB");
                result = false;
            }
            else if (!regex.IsMatch(client.Province))
            {
                errors.Add("Enter a valid Province");
                result = false;
            }

            //Validate proper Canadian postal code
            regex = new Regex("^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]*$");

            if (string.IsNullOrWhiteSpace(client.PostalCode) || client.PostalCode.Length < 7)
            {
                errors.Add("Postal Code must follow pattern: A9A 9A9");
                result = false;
            }
            else if (!regex.IsMatch(client.PostalCode))
            {
                errors.Add("Enter a valid Postal Code");
                result = false;
            }

            if (client.YTDSales < 0)
            {
                errors.Add("YTD Sales must not be less than 0");
                result = false;
            }

            return result;
        }
    }
}