using DataLayer.Common;
using DataLayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataLayer.Business
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
            
            if (client.ClientCode.Length < 5 || client.ClientCode == null || client.ClientCode == string.Empty)
            {                
                errors.Add("Client Code must be 5 uppercase alpha characters");
                result = false;
            }

            if (client.CompanyName == null || client.CompanyName == string.Empty)
            {                
                errors.Add("Company Name cannot be empty");
                result = false;
            }

            if (client.Address1 == null || client.Address1 == string.Empty)
            {                
                errors.Add("Address1 cannot be empty");
                result = false;
            }

            //Validate proper Canadian province
            //Regex regex = new Regex("^[ABMNOPQSY][BCEKLNSTU]*$");
            //!regex.IsMatch(client.Province)
            if (client.Province == null || client.Province == string.Empty)
            {                
                errors.Add("Province cannot be empty");
                result = false;
            }
            else if (client.Province.Length < 2)
            {                
                errors.Add("Province must be 2 uppercase alpha characters");
                result = false;
            }

            //Validate proper Canadian postal code
            //regex = new Regex("^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]*$");
            //!regex.IsMatch(client.PostalCode)
            if (client.PostalCode == null || client.PostalCode == string.Empty || client.PostalCode.Length < 7)
            {
                errors.Add("Postal Code is not in the right format ex: L0L 0L0");
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