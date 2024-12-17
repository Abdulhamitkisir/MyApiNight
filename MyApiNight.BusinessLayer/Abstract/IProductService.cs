using MyApiNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.BusinessLayer.Abstract
{
    public interface IProductService :IGenericService<Product>
    {
        public int TGetProductCount();
    }
}
