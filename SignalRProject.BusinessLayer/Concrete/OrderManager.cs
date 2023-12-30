using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DataAccessLayer.Abstract;
using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public int ActiveOrderCount()
        {
            return _orderDal.ActiveOrderCount();
        }

        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal LastOrderPrice()
        {
            return _orderDal.LastOrderPrice();
        }

        public decimal TodayTotalPrice()
        {
            return _orderDal.TodayTotalPrice();
        }

        public int TotalOrderCount()
        {
            return _orderDal.TotalOrderCount();
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
