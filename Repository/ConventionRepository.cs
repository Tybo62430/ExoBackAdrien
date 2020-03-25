using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class ConventionRepository : CrudRepository<Convention>
    {
        private stage_entrepriseContext context;
        public ConventionRepository(stage_entrepriseContext context)
        {
            this.context = context;
        }
        public IQueryable<Convention> Filter(Convention model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Convention> FindAll()
        {
            return this.context.Convention;
        }

        public Convention FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Convention> Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Convention Save(Convention model)
        {
            throw new NotImplementedException();
        }

        public Convention Update(Convention model)
        {
            throw new NotImplementedException();
        }
    }
}
