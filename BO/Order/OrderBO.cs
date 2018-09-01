using BO.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Order
{
    public class OrderBO
    {
        public OrderBO()
        {
            orderdetails = new List<OrderDetailBO>();
        }
        public int OrderID
        {
            get;
            set;
        }
        public string OrderNumber
        {
            get;
            set;
        }
        public DateTime OrderDate
        {
            get;
            set;
        }
        public decimal Amount
        {
            get;
            set;
        }
        public decimal Discount
        {
            get;
            set;
        }
        public int AddresID
        {
            get;
            set;
        }
        public int CustomerID
        {
            get;
            set;
        }
        public int ProductID
        {
            get;
            set;
        }
        public int DetailID
        {
            get;
            set;
        }
        public decimal TotalAmount
        {
            get;
            set;
        }
        public decimal TotalDiscount
        {
            get;
            set;
        }
        public decimal TotalPrice
        {
            get;
            set;
        }
     
        public int ID { get; set; }
        public OrderDetailBO OrderDetailBO { get; set; }
        public List<OrderDetailBO> orderdetails { get; set; }
    }
}