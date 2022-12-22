using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,DbCafeContext>,IOrderDal
    {
    }
}
