using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO.Customer;
using Data_Repository.Model;
using System.Data.Entity.Validation;

namespace Data_Repository.Registration
{
    public class CustomerRepository : Interface.ICustomer
    {
        private UserRegistrationEntities _db = new UserRegistrationEntities();

        public int AddCustomer(CustomerBO customer)
        {
            Customer cust = new Customer();
            try
            {

                cust.FirstName = customer.FirstName;
                cust.LastName = customer.LastName;
                cust.Email = customer.Email;
                cust.PhoneNumber = customer.PhoneNumber;
                _db.Customers.Add(cust);
                _db.SaveChanges();
                return cust.CustomerID;
            }

            catch (DbEntityValidationException dbEx)
            {
                foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError error in entityErr.ValidationErrors)
                    {
                        Console.WriteLine("Error Property Name {0} : Error Message: {1}",
                                            error.PropertyName, error.ErrorMessage);
                    }
                }
                return cust.CustomerID;

            }
        }



        public List<CustomerBO> GetAddres(int id)
        {
            throw new NotImplementedException();
        }

        /* public List<Customer> GetAddres<Customer>(int id)
        {
            var customer = _db.Customers.Where(e => e.CustomerID == id).ToList();
            return null;
        } */
    }
}
       
