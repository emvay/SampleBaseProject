using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Entities.Concrete;

namespace Training.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
