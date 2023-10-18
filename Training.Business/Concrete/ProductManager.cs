using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Abstract;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Concrete;

namespace Training.Business.Concrete
{
    public class ProductManager
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll() 
        {  
            return _productDal.GetAll();
        }
        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetByCategoryID(categoryId);
        }
    }
}
