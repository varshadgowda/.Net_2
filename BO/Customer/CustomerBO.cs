using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Customer
{
   public  class CustomerBO
    {
        public CustomerBO()
        {

        }
        public int CustomerID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
