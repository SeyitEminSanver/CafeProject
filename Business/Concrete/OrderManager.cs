using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete.Dto;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager:IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Message.OrderAdd);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccesDataResult<List<Order>>(_orderDal.GetAll(), Message.ProductsListed);
        }

        public IDataResult<List<OrderDetails>> GetOrderDetails()
        {
            return new SuccesDataResult<List<OrderDetails>>(_orderDal.GetOrderDetails(), Message.GetOrderDetails);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Message.OrderUpdated);
        }
    }
}
