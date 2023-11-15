using Training.Entities.Concrete;

namespace Training.Business.Abstract
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
    }
}
