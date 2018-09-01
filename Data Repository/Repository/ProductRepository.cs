using BO.Product;
using Data_Repository.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Repository.Registration
{
   public class ProductRepository : Interface.IProduct
    {
        private UserRegistrationEntities _db = new UserRegistrationEntities();

       public int AddProduct(ProductBO product)
        {
            try
            {
               
               List<ProductDescription>  descr = new List<ProductDescription>();
                Product prod = new Product();
                prod.ProductName = product.ProductName;
                prod.ProductDescription = product.ProductDescription;
                foreach (var item in product.DescriptionBO)
                {
                    ProductDescription desc = new ProductDescription();
                    desc.Size = item.Size;
                    desc.UnitPrice = item.UnitPrice;
                    desc.QualityType = item.QualityType;
                    desc.Discount = item.Discount;
                    descr.Add(desc);
                }
                prod.ProductDescriptions = descr;
                _db.Products.Add(prod);
                _db.SaveChanges();
                return prod.ProductID;
            }
          
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductBO> GetProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
