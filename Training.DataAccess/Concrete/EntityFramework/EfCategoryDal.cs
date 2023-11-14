using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Abstract;
using Training.Entities.Concrete;

namespace Training.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TrainingContext>, ICategoryDal
    {
    }
}
