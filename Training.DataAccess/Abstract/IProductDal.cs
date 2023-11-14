using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Concrete.EntityFramework;
using Training.Entities.Abstract;
using Training.Entities.Concrete;

namespace Training.DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {

    }
}
