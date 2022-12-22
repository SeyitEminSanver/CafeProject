using Core.Utilities.Results.Abstract;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();

        IDataResult<List<Category>> GetAllByCategoryId(int id);

        IResult Add(Category category);

        IResult Update(Category category);
    }
}
