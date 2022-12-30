using Core.Utilities.Results.Abstract;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITableService
    {
        IResult Add(Table table);

        IDataResult<List<Table>> GetAll();

        IResult Update(Table table);
    }
}
