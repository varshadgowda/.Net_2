using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BO.Customer;
using Data_Repository.Interface;
using Data_Repository.Registration;
using System.Web;

namespace UserRegistration.Controllers
{
   
    public class CustomerController : ApiController
    {
        private ICustomer icustomers = new CustomerRepository();
        [HttpPost]
        public HttpResponseMessage insertCustomer(CustomerBO  customer)
        {
           int custs= icustomers.AddCustomer(customer);
            var session = HttpContext.Current.Session;
            if (session != null)
            {
                HttpContext.Current.Session["CustomerID"] = custs;
            }
            return Request.CreateResponse(HttpStatusCode.OK, "inserted successfully");
        }
    }
}
