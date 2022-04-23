using Business.Abstract;
using Core.Utilities.Abstract.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public void Add(Category category)
        {
           
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        IResult ICategoryService.Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        IResult ICategoryService.Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();
        }

        IDataResult<List<Category>> ICategoryService.GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        IDataResult<Category> ICategoryService.GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x => x.CategoryId == id));
        }

        IResult ICategoryService.Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();
        }
    }
}
