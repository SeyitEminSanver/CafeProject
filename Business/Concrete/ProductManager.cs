using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete.EntityFramework;
using Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
           _productDal.Add(product);
            return new SuccessResult(Message.ProductAdded);
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
    }
}
