using OrderService.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
  public  interface IOrderRepository
    {
        List<Orders> GetAllOrders();
        Orders GetById(string id);
        void AddOrders(Orders obj);
        void DeleteOrders(string id);
        //void UpdateOrders(Items obj);
    }
}

