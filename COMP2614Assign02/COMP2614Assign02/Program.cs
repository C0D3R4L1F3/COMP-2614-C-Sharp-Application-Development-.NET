using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    /// <summary>
    /// Runs the methods if valid args are passed
    /// </summary>
    class Program
    {
        /// <summary>
        /// Drives the program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Program start = new Program();
            start.run();
        }

        /// <summary>
        /// Runs the method for populateContacts
        /// </summary>
        private void run()
        {
            populateContacts();
        }

        /// <summary>
        /// Method that calls default constructor and initializes a Contact
        /// </summary>
        /// <param name="enterFirstName">First name of contact</param>
        /// <param name="enterLastName">Last name of contact</param>
        /// <param name="enterAddress">Address of contact</param>
        /// <param name="enterCity">City of contact</param>
        /// <param name="enterProvince">Province of contact</param>
        /// <param name="enterPostalCode">Postal code of contact</param>
        /// <returns>contactOne</returns>
        private Contact objectOneInit(string enterFirstName, string enterLastName, string enterAddress, string enterCity, string enterProvince, string enterPostalCode)
        {
            Contact contactOne = new Contact();
            contactOne.FirstName = enterFirstName;
            contactOne.LastName = enterLastName;
            contactOne.Address = enterAddress;
            contactOne.City = enterCity;
            contactOne.Province = enterProvince;
            contactOne.PostalCode = enterPostalCode;
            return contactOne;
        }

        /// <summary>
        /// Method that requests and reads contact information
        /// </summary>
        /// <param name="enterFirstName">First name of contact</param>
        /// <param name="enterLastName">Last name of contact</param>
        /// <param name="enterAddress">Address of contact</param>
        /// <param name="enterCity">City of contact</param>
        /// <param name="enterProvince">Province of contact</param>
        /// <param name="enterPostalCode">Postal code of contact</param>
        private void requestContactInfo(out string enterFirstName, out string enterLastName, out string enterAddress, out string enterCity, out string enterProvince, out string enterPostalCode)
        {
            Console.WriteLine("Contact Information");
            Console.WriteLine(new string('-', 30));

            Console.Write("Firstname: ");
            enterFirstName = Console.ReadLine();
            Console.Write("Lastname: ");
            enterLastName = Console.ReadLine();
            Console.Write("Address: ");
            enterAddress = Console.ReadLine();
            Console.Write("City: ");
            enterCity = Console.ReadLine();
            Console.Write("Province: ");
            enterProvince = Console.ReadLine();
            Console.Write("Postal Code: ");
            enterPostalCode = Console.ReadLine();
        }

        /// <summary>
        /// Populates the contact list
        /// </summary>
        private void populateContacts()
        {
            string enterFirstName;
            string enterLastName;
            string enterAddress;
            string enterCity;
            string enterProvince;
            string enterPostalCode;

            // Request for contact information
            requestContactInfo(out enterFirstName, out enterLastName, out enterAddress, out enterCity, out enterProvince, out enterPostalCode);

            // Creates object through property methods
            Contact contactOne = objectOneInit(enterFirstName, enterLastName, enterAddress, enterCity, enterProvince, enterPostalCode);

            // Creates object through parameterized constructor
            Contact contactTwo = new Contact(enterFirstName, enterLastName, enterAddress, enterCity, enterProvince, enterPostalCode);

            // Creates object through Object Initializer syntax
            Contact contactThree = new Contact { FirstName = enterFirstName, LastName = enterLastName, Address = enterAddress, City = enterCity, Province = enterProvince, PostalCode = enterPostalCode };

            // Creates an array of contacts
            Contact[] contacts = new Contact[3];
            contacts[0] = contactOne;
            contacts[1] = contactTwo;
            contacts[2] = contactThree;

            Console.WriteLine("Contacts");
            Console.WriteLine(new string('-', 30));

            // Loops through the array and prints objects
            foreach (Contact contact in contacts)
            {
                ConsolePrinter.Print(contact);
            }
        }
    }
}