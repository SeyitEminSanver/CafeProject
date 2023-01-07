using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRules.Run(CheckIfNameExsist(product.ProductName));
            if (result != null)
            {
                return result;
            }
           _productDal.Add(product);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResult Delete(Product product)
        {
          _productDal.Delete(product);

            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(), Message.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IResult Update(Product product)
        {
           _productDal.Update(product);
            return new SuccessResult(Message.ProductUpdated);
        }

        private IResult CheckIfNameExsist(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Message.ProductNameAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}
