using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.ProductDescription
{
    public class DescriptionBO
    {
        public DescriptionBO() { }

        public int DescriptonID { get; set;}

        public string Size { get; set;}

        public decimal UnitPrice { get; set;}

        public string QualityType{ get; set;}

        public decimal Discount{ get; set;}

        public int ID { get; set; }
    }
}
