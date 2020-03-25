using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    interface CrudRepository<T>
    {
        public IQueryable<T> Filter(T model);
        public IQueryable<T> FindAll();
        public T FindById(int id);
        public IQueryable<T> Remove(int Id);
        public T Update(T model);
        public T Save(T model);
    }
}
