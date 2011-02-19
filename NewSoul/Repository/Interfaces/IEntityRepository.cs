using System;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IEntityRepository<T>
    {
        T Create(T image);
        void Update(T image);
        void Delete(T image);
        T Get(Guid imageId);
        List<T> GetList(Func<T, bool> searchCriteria);
        List<T> GetList(Func<T, bool> searchCriteria, Func<T, object> orderCriteria, int count, int pageNumber);
    }

}
