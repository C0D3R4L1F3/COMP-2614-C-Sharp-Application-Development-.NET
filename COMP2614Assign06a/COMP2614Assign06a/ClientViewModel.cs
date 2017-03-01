using COMP2614Assign06a.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06a.Util
{
    /// <summary>
    /// Representation class for Client objects
    /// </summary>
    class ClientViewModel : INotifyPropertyChanged
    {
        private string clientCode;
        private string companyName;
        private string address1;
        private string address2;
        private string province;
        private string city;
        private string postalCode;
        private decimal ytdSales;
        private bool creditHold;
        private string notes;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to change property from an event
        /// </summary>
        /// <param name="propertyName">the propertyName to set</param>
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Constructor to initialize a ClientViewModel object
        /// </summary>
        /// <param name="clients">the clients to set</param>
        public ClientViewModel(ClientCollection clients)
        {
            this.Clients = clients;
        }

        /// <summary>
        /// Property field ClientCode
        /// </summary>
        public string ClientCode
        {
            get { return clientCode; }
            set
            {
                clientCode = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field CompanyName
        /// </summary>
        public string CompanyName
        {
            get { return companyName; }
            set
            {
                companyName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Address1
        /// </summary>
        public string Address1
        {
            get { return address1; }
            set
            {
                address1 = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Address2
        /// </summary>
        public string Address2
        {
            get { return address2; }
            set
            {
                address2 = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Province
        /// </summary>
        public string Province
        {
            get { return province; }
            set
            {
                province = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field City
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field PostalCode
        /// </summary>
        public string PostalCode
        {
            get { return postalCode; }
            set
            {
                postalCode = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field YTDSales
        /// </summary>
        public decimal YTDSales
        {
            get { return ytdSales; }
            set
            {
                ytdSales = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field CreditHold
        /// </summary>
        public bool CreditHold
        {
            get { return creditHold; }
            set
            {
                creditHold = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Notes
        /// </summary>
        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Clients
        /// </summary>
        public ClientCollection Clients { get; set; }

        /// <summary>
        /// Method to set display client
        /// </summary>
        /// <param name="client">the client to set</param>
        public void SetDisplayClient(Client client)
        {
            this.ClientCode = client.ClientCode;
            this.CompanyName = client.CompanyName;
            this.Address1 = client.Address1;
            this.Address2 = client.Address2;
            this.City = client.City;
            this.Province = client.Province;
            this.PostalCode = client.PostalCode;
            this.YTDSales = client.YTDSales;
            this.CreditHold = client.CreditHold;
            this.Notes = client.Notes;
        }

        /// <summary>
        /// Method to save a client changes of information
        /// </summary>
        /// <param name="collectionIndex">the collectionIndex to set</param>
        /// <returns>Clients[collectionIndex]</returns>
        public Client SaveClient(int collectionIndex)
        {
            this.Clients[collectionIndex].ClientCode = this.clientCode;
            this.Clients[collectionIndex].CompanyName = this.CompanyName;
            this.Clients[collectionIndex].Address1 = this.Address1;
            this.Clients[collectionIndex].Address2 = this.Address2;
            this.Clients[collectionIndex].City = this.City;
            this.Clients[collectionIndex].Province = this.Province;
            this.Clients[collectionIndex].PostalCode = this.PostalCode;
            this.Clients[collectionIndex].YTDSales = this.YTDSales;
            this.Clients[collectionIndex].CreditHold = this.CreditHold;
            this.Clients[collectionIndex].Notes = this.Notes;

            return this.Clients[collectionIndex];
        }
    }
}