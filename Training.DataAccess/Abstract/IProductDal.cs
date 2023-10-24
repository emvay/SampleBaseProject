using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Concrete;

namespace Training.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        public List<Product> GetAll();

        public Product GetById(int id);
        public List<Product> GetByCategoryID(int categoryId);
        public void Add(Product product);
        public void Update(Product product);

        public void Delete(Product product);
    }
}
