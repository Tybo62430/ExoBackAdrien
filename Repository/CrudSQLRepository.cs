using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using Domaine;
    using Microsoft.EntityFrameworkCore;
    public class CrudSQLRepository<T> : CrudRepository<T> where T : Model
    {
        private stage_entrepriseContext context = null;
        private DbSet<T> table = null;

        public CrudSQLRepository(stage_entrepriseContext context)
        {
            this.context = context;
            this.table = context.Set<T>();
        }

        public IQueryable<T> Filter(T model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            return this.table;
        }

        public T FindById(int id)
        {
            return this.table.Where(Model => Model.Id == id).First();
        }

        public void Remove(int id)
        {
            this.context.Remove(this.FindById(id));
            this.context.SaveChanges();
        }

        public T Save(T model)
        {
            this.context.Add(model);
            this.context.SaveChanges();
            return model;
        }

        public T Update(T model)
        {
            this.context.Update(model);
            this.context.SaveChanges();
            return model;
        }
    }
}
