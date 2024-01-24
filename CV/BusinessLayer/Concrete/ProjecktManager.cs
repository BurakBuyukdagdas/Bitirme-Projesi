using BusinessLayer.Abstrackt;
using DataAccessLayer.Abstrackt;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjecktManager : IProjecktService
    {
        IProjectDal _projectDal;

        public ProjecktManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void TAdd(Project t)
        {
            _projectDal.Insert(t);
        }

        public void TDelete(Project t)
        {
            _projectDal.Delete(t);
        }

        public List<Project> TGetList()
        {
            return _projectDal.GetList();
        }

        public Project TGetByID(int id)
        {
            return _projectDal.GetByID(id);
        }

        public void Tupdate(Project t)
        {
            _projectDal.Update(t);
        }
    }
}
