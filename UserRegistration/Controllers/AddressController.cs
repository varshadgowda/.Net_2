using BO.Address;
using Data_Repository.Interface;
using Data_Repository.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace UserRegistration.Controllers
{
   public class AddressController : ApiController
    {
        private IAddres iaddres = new AddresRepository();
        [HttpPost]
        public HttpResponseMessage insertAddres(AddresBO address)
        {
            address.CustomerID = (int)HttpContext.Current.Session["CustomerID"];
            int addrs = iaddres.AddAddres(address);
            var session = HttpContext.Current.Session;
            if (session != null)
            {
                HttpContext.Current.Session["AddresID"] = addrs;
            }
            return Request.CreateResponse(HttpStatusCode.OK, "saved successfully");
        }
    }
}
