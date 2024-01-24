using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrackt
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void Tupdate(T t);
        List<T> TGetList(); //Videoda GetList karşılığı. DataAccessLayer -> Repository -> GenericRepository.cs
        T TGetByID(int id);

    }
}
