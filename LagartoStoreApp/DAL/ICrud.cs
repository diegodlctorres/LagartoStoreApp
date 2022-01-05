using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagartoStoreApp.DAL
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
