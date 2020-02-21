﻿
using OrderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDBContext _context;
        public OrderRepository(ShopDBContext context)
        {
            _context = context;
        }
        public void AddOrders(Orders obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteOrders(string id)
        {
            Items item = _context.Items.Find(id);
            _context.SaveChanges();
        }

        public List<Orders> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Orders GetById(string id)
        {
            return _context.Orders.Find(id);
        }

        //public void UpdateOrders(Items obj)
        //{
        //    _context.Items.Update(obj);
        //    _context.SaveChanges();
        //}
    }
}
