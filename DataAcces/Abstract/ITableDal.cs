using Core.DataAcces;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface ITableDal:IEntityRepository<Table>
    {
    }
}
