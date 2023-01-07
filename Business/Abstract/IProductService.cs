using Core.Utilities.Results.Abstract;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetAllByCategoryId(int id);

        IResult Add(Product product);

        IResult Update(Product product);

        IResult Delete(Product product);

    }
}
