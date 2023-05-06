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
    public class WriterManager : IWriterService
    {

        IWriterDal _writerDal;

        public WriterManager(IWriterDal WriterDal)
        {
            _writerDal= WriterDal;
        }

        public List<Writer> GetAll()
        {
            return _writerDal.GetAll();
        }
    }
}
