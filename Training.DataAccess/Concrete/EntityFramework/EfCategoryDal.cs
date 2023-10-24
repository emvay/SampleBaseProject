using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.DataAccess.Abstract;
using Training.Entities.Concrete;

namespace Training.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:ICategoryDal
    {
        public List<Category> GetAll()
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                return trainingContext.Categories.ToList();
            }
        }


        public void Add(Category category)
        {
            
        }


        public void Delete(Category category)
        {
            
        }


        public Category GetById(int id)
        {
            using (TrainingContext trainingContext = new TrainingContext())
            {
                return trainingContext.Categories.SingleOrDefault(c=>c.CategoryID==id);
            }
        }


        public void Update(Category category)
        {
            
        }
    }
}
