using BO.Order;
using Data_Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Registration
{
    public class OrderDetailRepository : Interface.IOrder
    {
        private UserRegistrationEntities _db = new UserRegistrationEntities();

        public int AddOrders(OrderBO order)
        {
            try
            {

                List<OrderDetail> orde = new List<OrderDetail>();
                Order ordr = new Order();
                ordr.OrderNumber = order.OrderNumber;
                ordr.OrderDate = order.OrderDate;
                ordr.Amount = order.Amount;
                ordr.Discount = order.Discount;
                ordr.AddresID = order.AddresID;
                foreach (var item in order.orderdetails)
                {
                    OrderDetail ordet = new OrderDetail();
                    ordet.CustomerID = order.CustomerID;
                    ordet.ProductID = item.ProductID;
                    ordet.TotalAmount = item.TotalAmount;
                    ordet.TotalDiscount = item.TotalDiscount;
                    ordet.TotalPrice = item.TotalPrice;
                    ordet.OrderQuantity = item.OrderQuantity;
                    ordet.IndividualPriceOfProduct = item.IndividualPriceOfProduct;
                    ordet.OrderDeliveryDate = item.OrderDeliveryDate;
                    ordet.OrderStatus = item.OrderStatus;
                    orde.Add(ordet);
                }
                ordr.OrderDetails = orde;
                _db.Orders.Add(ordr);
                _db.SaveChanges();
                return ordr.OrderID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OrderBO> GetOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
