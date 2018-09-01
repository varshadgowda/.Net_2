using BO.Order;
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
    public class OrdersController : ApiController
    {
        private IOrder iorder = new OrderDetailRepository();
        [HttpPost]
        public HttpResponseMessage insertOrder(OrderBO order)
        {
            int ordrs = iorder.AddOrders(order);
            return Request.CreateResponse(HttpStatusCode.OK, "saved successfully");
        }
    }
}
