using BO.Product;
using Data_Repository.Interface;
using Data_Repository.Registration;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace UserRegistration.Controllers
{
    public class ProductController : ApiController
    {
        private IProduct iproducts = new ProductRepository();
        [HttpPost]
        public HttpResponseMessage insertProduct(ProductBO product)
        {
            int produ = iproducts.AddProduct(product);
            var session = HttpContext.Current.Session;
            if(session != null)
            {
                HttpContext.Current.Session["ProductID"] = produ;
            }
            return Request.CreateResponse(HttpStatusCode.OK, "saved successfully");
        }

    }
}
