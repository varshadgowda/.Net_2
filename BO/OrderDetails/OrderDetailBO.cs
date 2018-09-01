using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.OrderDetails
{
   public class OrderDetailBO
    {
        public OrderDetailBO() { }
        
        public decimal TotalAmount { get; set; }
       
        public decimal TotalDiscount { get; set; }
        
        public decimal TotalPrice { get; set; }
       
        public int CustomerID { get; set; }
        
        public int ProductID { get; set; }

        public string OrderQuantity { get; set; }

        public decimal IndividualPriceOfProduct { get; set; }
        
        public DateTime OrderDeliveryDate { get; set; }
       
        public string OrderStatus { get; set; }

        public int ID { get; set; }

    }
}
