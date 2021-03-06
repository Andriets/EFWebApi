﻿using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using DAL.Owner_Parameters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork UOW; 
        public OrderService(IUnitOfWork unitOfWork)
        {
            UOW = unitOfWork;
        }
        public void Delete(int id)
        {
            UOW.OrderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll(PagingParameters pagingParameters)
        {
            return UOW.OrderRepository.GetOrders(pagingParameters);
        }

        public Order GetById(int id)
        {
            return UOW.OrderRepository.GetById(id).Result;
        }

        public void Insert(Order obj)
        {
            UOW.OrderRepository.Insert(obj);
        }

        public void Update(Order obj)
        {
            UOW.OrderRepository.Update(obj);
        }
    }
}
