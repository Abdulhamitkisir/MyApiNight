using MyApiNight.BusinessLayer.Abstract;
using MyApiNight.DataAccessLayer.Abstract;
using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productService)
        {
            _productDal = productService;
        }

        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();    
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public int TGetProductCount()
        {
           return _productDal.GetProductCount();
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
