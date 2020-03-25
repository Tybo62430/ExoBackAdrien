using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class EntrepriseRepository : CrudRepository<Entreprise>
    {
        private stage_entrepriseContext context;

        public EntrepriseRepository(stage_entrepriseContext context)
        {
            this.context = context;
        }

        public IQueryable<Entreprise> Filter(Entreprise model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entreprise> FindAll()
        {
            return this.context.Entreprise;
        }

        public Entreprise FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entreprise> Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Entreprise Save(Entreprise model)
        {
            throw new NotImplementedException();
        }

        public Entreprise Update(Entreprise model)
        {
            throw new NotImplementedException();
        }
    }
