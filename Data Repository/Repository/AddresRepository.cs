
using BO.Address;
using Data_Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Registration
{
    public class AddresRepository : Interface.IAddres
        {
            private UserRegistrationEntities _db = new UserRegistrationEntities();

            public int AddAddres(AddresBO address)
            {
                try
                {
                    Addre addr = new Addre();
                    addr.AddressType = address.AddressType;
                    addr.Addres = address.Address;
                    addr.City = address.City;
                    addr.States = address.State;
                    addr.Country = address.Country;
                    addr.pincode = address.pincode;
                    addr.CustomerID = address.CustomerID;
                    _db.Addres.Add(addr);
                    _db.SaveChanges();
                    return addr.AddresID;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public List<AddresBO> GetAddres(int id)
            {
                throw new NotImplementedException();
            }
        }

        /* public List<Addre> GetAddres<Addre>(int id)
        {
            var address = db.Addres.Where(e => e.AddresID == id).ToList();
            return null;
        } */
    }