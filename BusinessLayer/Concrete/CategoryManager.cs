using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryDal
    {

        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository= new EfCategoryRepository();
        }

        public void Delete(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public List<Category> GetAll()
        {
            return efCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public void Insert(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void Update(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
