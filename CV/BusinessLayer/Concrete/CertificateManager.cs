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
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;

        public CertificateManager(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public void TAdd(Certificate t)
        {
            _certificateDal.Insert(t);
        }

        public void TDelete(Certificate t)
        {
            _certificateDal.Delete(t);
        }

        public List<Certificate> TGetList()
        {
            return _certificateDal.GetList();
        }

        public Certificate TGetByID(int id)
        {
             return _certificateDal.GetByID(id);
        }

        public void Tupdate(Certificate t)
        {
            _certificateDal.Update(t);
        }
    }
}
