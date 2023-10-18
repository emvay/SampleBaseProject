using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Entities.Concrete;

namespace Training.DataAccess.Concrete.EntityFramework
{
    public class CategoryDal
    {
        public List<Category> GetAll()
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                return trainingContext.Categories.ToList();
            }
        }
    }
}
