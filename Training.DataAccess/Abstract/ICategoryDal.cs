using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Concrete;

namespace Training.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        public List<Category> GetAll();
    }
}
