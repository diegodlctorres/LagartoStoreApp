using System.Collections.Generic;

namespace DataAccessLayer
{
    internal interface ICrud<T>
    {
        public void Create(T entidad);

        public void Delete(int id);

        public List<T> GetAll();

        public T GetByID(int id);

        public void Update(T entidad);
    }
}
