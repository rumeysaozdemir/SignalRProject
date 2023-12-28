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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> GetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> GetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public int ProductCount()
        {
            return _productDal.ProductCount();
        }

        public int ProductCountByCategoryNameDrink()
        {
            return _productDal.ProductCountByCategoryNameDrink();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            return _productDal.ProductCountByCategoryNameHamburger();
        }

        public string ProductNameByMaxPrice()
        {
            return _productDal.ProductNameByMaxPrice();
        }

        public string ProductNameByMinPrice()
        {
            return _productDal.ProductNameByMinPrice();
        }

        public decimal ProductPriceAvg()
        {
           return _productDal.ProductPriceAvg();
        }

        public decimal ProductAvgPriceByHamburger()
        {
            return _productDal.ProductAvgPriceByHamburger();
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
