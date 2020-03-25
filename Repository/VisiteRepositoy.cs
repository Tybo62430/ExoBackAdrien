using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class VisiteRepositoy : CrudRepository<Visite>
    {
        private stage_entrepriseContext context;

        public VisiteRepositoy(stage_entrepriseContext context)
        {
            this.context = context;
        }

        public IQueryable<Visite> Filter(Visite model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Visite> FindAll()
        {
            return this.context.Visite;
        }

        public Visite FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Visite> Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Visite Save(Visite model)
        {
            throw new NotImplementedException();
        }

        public Visite Update(Visite model)
        {
            throw new NotImplementedException();
        }
    }
}
