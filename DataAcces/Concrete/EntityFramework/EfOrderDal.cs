using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete.Dto;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, DbCafeContext>, IOrderDal
    {
        public List<OrderDetails> GetOrderDetails()
        {
            using ( DbCafeContext context = new DbCafeContext())
            {
                var result = from p in context.products
                             join o in context.Orders
                             on p.ProductId equals o.ProductId
                             select new OrderDetails
                             {
                                 ProductName=p.ProductName,
                                 Price=p.Price,
                                 Count=o.Count
                             };
                return result.ToList();

            }

        }
       
    }
}
