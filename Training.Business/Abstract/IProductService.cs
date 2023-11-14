using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Training.Entities.Abstract;
using Training.Entities.Concrete;

namespace Training.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string productName);
    }
}
