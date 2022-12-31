using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAcces.Abstract;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TableManager : ITableService
    {
        private readonly ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }
        public IResult Delete(Table table)
        {
            _tableDal.Delete(table);
            return new SuccessResult();
        }

        public IResult Add(Table table)
        {
            _tableDal.Add(table);
            return new SuccessResult();
        }

        public IDataResult<List<Table>> GetAll()
        {
            return new SuccesDataResult<List<Table>>(_tableDal.GetAll());
        }

        public IResult Update(Table table)
        {
            _tableDal.Update(table);
            return new SuccessResult();
        }
    }
}
