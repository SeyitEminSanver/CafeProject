
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(category.CategoryName));
            if(result!=null)
            {
                return result;
            }
            _categoryDal.Add(category);
            return new SuccessResult(Message.CategoryAdded);
        }

       

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccesDataResult<List<Category>>(_categoryDal.GetAll(),Message.CategoryListed);
        }

        public IDataResult<List<Category>> GetAllByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Category category)
        {
            throw new NotImplementedException();
        }
        private IResult CheckIfProductNameExists(string categoryName)
        {
            var result = _categoryDal.GetAll(p => p.CategoryName == categoryName).Any();
            if(result)
            {
                return new ErrorResult(Message.CategoryNameAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
