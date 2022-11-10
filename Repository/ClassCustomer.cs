using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassCustomer : ClassNotify
    {
        // Private Properties
        private string _companyName;
        private string _address;
        private string _zipCity;
        private string _phone;
        private string _mail;
        private string _contactName;
        private int _id;
        private ClassCountry _country;

        // Constructor
        public ClassCustomer()
        {
            companyName = "";
            address = "";
            zipCity = "";
            phone = "";
            mail = "";
            contactName = "";
            id = 0;
            country = new ClassCountry();
        }

        // Overloaded Constructor til at lave en kopi
        public ClassCustomer(ClassCustomer inCustomer)
        {
            companyName = inCustomer.companyName;
            address = inCustomer.address;
            zipCity = inCustomer.zipCity;
            phone = inCustomer.phone;
            mail = inCustomer.mail;
            contactName = inCustomer.contactName;
            id = inCustomer.id;
            country = inCustomer.country;
        }

        // Public Properties
        // holder kundens id
        public int id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                }
                Notify("id");
            }
        }

        // Holder navnet på kundens kontakt person
        public string contactName
        {
            get { return _contactName; }
            set
            {
                if (_contactName != value)
                {
                    _contactName = value;
                }
                Notify("contactName");
            }
        }

        // Holder navnet på kundens email
        public string mail
        {
            get { return _mail; }
            set
            {
                if (_mail != value)
                {
                    _mail = value;
                }
                Notify("mail");
            }
        }
        
        // Holder navnet på kundens mobil nummer
        public string phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                }
                Notify("phone");
            }
        }

        // Holder navnet på kundens zipcode
        public string zipCity
        {
            get { return _zipCity; }
            set
            {
                if (_zipCity != value)
                {
                    _zipCity = value;
                }
                Notify("zipCity");
            }
        }

        // Holder navnet på kundens addresse 
        public string address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                }
                Notify("address");
            }
        }

        // Holder navnet på kundens navn
        public string companyName
        {
            get { return _companyName; }
            set
            {
                if (_companyName != value)
                {
                    _companyName = value;
                }
                Notify("companyName");
            }
        }

        // Holder navnet på kundens land
        public ClassCountry country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;
                }
                Notify("country");
            }
        }

        /// <summary>
        /// Checks that all properties have a non-empty value
        /// </summary>
        /// <returns>True or False</returns>
        public bool AreAllFieldsFilled()
        {
            if (companyName.Trim().Length > 0 &&
                address.Trim().Length > 0 &&
                zipCity.Trim().Length > 0 &&
                phone.Trim().Length > 0 &&
                mail.Trim().Length > 0 &&
                contactName.Trim().Length > 0 &&
                country.Id != 0)
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
