using BO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Interface
{
    public interface IProduct
    {
        List<ProductBO> GetProduct(int id);
        int AddProduct(ProductBO product);
    }
}
