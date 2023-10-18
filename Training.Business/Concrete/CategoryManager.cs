using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Concrete;

namespace Training.Business.Concrete
{
    public class CategoryManager
    {
        CategoryDal _categoryDal = new CategoryDal();
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
