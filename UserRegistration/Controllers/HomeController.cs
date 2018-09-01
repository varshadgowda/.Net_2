using BO.Address;
using BO.Customer;
using BO.Order;
using BO.OrderDetails;
using BO.Product;
using BO.ProductDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UserManager;

namespace UserRegistration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View("index123");
        }

        public ActionResult Customer()
        {
            CustomerBO customer = new CustomerBO();
            return View();
        }
           

      public ActionResult Datastore()
        {
            AddresBO address = new AddresBO();
            return View("Address", address);
        }
        public ActionResult Product()
        {
            ProductBO product = new ProductBO();
            return View(product);
        }
        public ActionResult ProductDescription()
        {
            ProductBO product = new ProductBO();
            List<DescriptionBO> description = new List<DescriptionBO>();
            product.DescriptionBO = description;
            return PartialView("Descript", product);
        }
        public ActionResult Orders()
        {
            OrderBO ordrs = new OrderBO();
            return View();
        }
        public ActionResult OrderDetail()
        {
            OrderBO order = new OrderBO();
            List<OrderDetailBO> detail = new List<OrderDetailBO>();
            order.orderdetails = detail;
            return PartialView("Detail", order);
        }
        [HttpPost]
        public ActionResult TestData(ProductBO product)
        {
            DescriptionBO descript = new DescriptionBO();
            descript.Size = product.Size;
            descript.UnitPrice = product.UnitPrice;
            descript.QualityType = product.QualityType;
            descript.Discount = product.Discount;
            product.DescriptionBO.Add(descript);
            return PartialView("Descript", product);
        }
        [HttpPost]
        public ActionResult Delete(ProductBO product, int id)
        {
            int del = id - 1;
            product.DescriptionBO.RemoveAt(del);
            return PartialView("Descript", product);
            
        }
        [HttpPost]
        public ActionResult Edit(ProductBO product, int id)
        {
            int edt = id - 1;
            product.ID = edt;
            List<DescriptionBO> list = new List<DescriptionBO>();
            foreach(var item in product.DescriptionBO)
            {
                item.ID = edt;
                list.Add(item);
            }
            product.DescriptionBO = list;
            return PartialView("Descript", product);
        }

        [HttpPost]
        public ActionResult TestOrder(OrderBO order)
        {
        
            List<OrderDetailBO> orderdet = new List<OrderDetailBO>();
            if (Session["orddt"]!= null)
                {
                    orderdet = Session["orddt"] as List<OrderDetailBO>;
                }
                orderdet.Add(order.OrderDetailBO);
                Session["orddt"] = orderdet;
                order.orderdetails = orderdet;
                ViewBag.hdnFlag = Session["orddt"];
                return PartialView("Detail", order);
        }
        [HttpPost]
        public ActionResult Save(OrderBO order)
        {
            order.orderdetails = Session["orddt"] as List<OrderDetailBO>;
            order.AddresID =(int)System.Web.HttpContext.Current.Session["AddresID"];
            order.CustomerID = (int)System.Web.HttpContext.Current.Session["CustomerID"];
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:54333/api/Orders/insertOrder");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<OrderBO>("OrderBO", order);
                postTask.Wait();

                var result = postTask.Result;
                return Json("Saved Successfully", JsonRequestBehavior.AllowGet);
            }
        }
               [HttpPost]
        public ActionResult Deletes(OrderBO order, int id)
        {
            int dele = id -1;
            List<OrderDetailBO> orderdata = new List<OrderDetailBO>();
            if (Session["orddt"] != null)
            {
                orderdata= Session["orddt"] as List<OrderDetailBO>;
            }
            Session["orddt"] = orderdata;
            order.orderdetails = orderdata;
            order.orderdetails.RemoveAt(dele);
            return PartialView("Detail", order);
        }
    }
}

