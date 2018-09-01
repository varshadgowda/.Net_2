using BO.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Interface
{
   public interface ICustomer
    {
        List<CustomerBO> GetAddres(int id);
       int  AddCustomer(CustomerBO customer);
    }
}
