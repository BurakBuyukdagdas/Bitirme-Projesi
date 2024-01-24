using DataAccessLayer.Abstrackt;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameworl
{
    public class EfAboutDal : GenericRepository<About>,IAboutDal
    {

    }
}
