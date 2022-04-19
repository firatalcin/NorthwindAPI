using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract.Results;
using Core.Utilities.Concrete.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if(product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductAddedInvalid);
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new Result(true, "Ürün Silindi");
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new Result(true, "Ürün Güncellendi");
        }

        public IDataResult<List<Product>> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
            return new DataResult<List<Product>>();
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return _productDal.GetAll(x => x.CategoryId == categoryId);
        }

        public IDataResult<Product> GetById(int id)
        {
            return _productDal.Get(x => x.ProductId == id);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(x => x.UnitPrice <= max && x.UnitPrice >= min);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

       
    }
}
