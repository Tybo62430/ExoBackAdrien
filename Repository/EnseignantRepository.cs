using ExoBackAdrien.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class EnseignantRepository : CrudRepository<Enseignant>
    {
        private stage_entrepriseContext context;

        public EnseignantRepository(stage_entrepriseContext context)
        {
            this.context = context;
        }
        public IQueryable<Enseignant> Filter(Enseignant model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Enseignant> FindAll()
        {
            return this.context.Enseignant;
        }

        public Enseignant FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Enseignant> Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Enseignant Save(Enseignant model)
        {
            throw new NotImplementedException();
        }

        public Enseignant Update(Enseignant model)
        {
            throw new NotImplementedException();
        }
    }
}
