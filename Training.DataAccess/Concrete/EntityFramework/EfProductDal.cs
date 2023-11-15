using Training.DataAccess.Abstract;
using Training.Entities.Concrete;

namespace Training.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,TrainingContext>,IProductDal
    {
 
    }
}
