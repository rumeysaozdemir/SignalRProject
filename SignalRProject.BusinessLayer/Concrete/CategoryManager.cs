using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DataAccessLayer.Abstract;
using SignalRProject.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public int ActiveCategoryCount()
        {
            return _categoryDal.ActiveCategoryCount();
        }

        public void Add(Category entity)
        {
           _categoryDal.Add(entity);
        }

        public int CategoryCount()
        {
            return _categoryDal.CategoryCount();
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public int PassiveCategoryCount()
        {
            return _categoryDal.PassiveCategoryCount();
        }

        public void Update(Category entity)
        {
           _categoryDal.Update(entity);
        }
    }
}

