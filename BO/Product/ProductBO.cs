using BO.ProductDescription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Product
{
   public class ProductBO
    {
        public ProductBO()
        {
            DescriptionBO = new List<DescriptionBO>();
        }
        public int ProductID
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public string ProductDescription
        {
            get;
            set;
        }
        public string Size
        {
            get;
            set;
        }
        public decimal UnitPrice
        {
            get;
            set;
        }
        public string QualityType
        {
            get;
            set;
        }
        public decimal Discount
        {
            get;
            set;
        }
        public int ID { get; set; }
        public List<DescriptionBO> DescriptionBO { get; set; }
        public DescriptionBO DescriptionBOInd { get; set; }
    }
}
