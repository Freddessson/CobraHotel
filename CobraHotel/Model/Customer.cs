using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        private string name;
        private string pnr;
        private string email;
        private string phone;
        private string address;

        public Customer()
        {

        }
        public Customer(string name, string pnr, string email, string phone, string address)
        {
            this.name = name;
            this.pnr = pnr;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Pnr
        {
            get
            {
                return pnr;
            }

            set
            {
                pnr = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }



    }
}
