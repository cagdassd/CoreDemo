using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal BlogDal)
        {
            _blogDal= BlogDal;
        }


        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }
    }
}
