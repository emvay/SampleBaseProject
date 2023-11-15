using Training.DataAccess.Abstract;
using Training.Entities.Concrete;

namespace Training.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, TrainingContext>, ICategoryDal
    {
    }
}
