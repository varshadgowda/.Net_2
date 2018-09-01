using BO.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Interface
{
   public interface IAddres
    {
        List<AddresBO> GetAddres(int id);
        int AddAddres(AddresBO address);
    }
}
