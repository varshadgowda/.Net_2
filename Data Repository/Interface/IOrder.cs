using BO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Interface
{
    public interface IOrder
    {
        List<OrderBO> GetOrder(int id);
        int AddOrders(OrderBO order);
    }
}
