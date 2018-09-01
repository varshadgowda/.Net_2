using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Address
{
    public class AddresBO
    {
        public AddresBO()
        {

        }
        public int AddresID
        {
            get;
            set;
        }
        public string AddressType
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string pincode
        {
            get;
            set;
        }
        public int CustomerID
        {
            get;
            set;
        }
    }
}
