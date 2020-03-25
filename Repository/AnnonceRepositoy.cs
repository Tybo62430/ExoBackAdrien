using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class AnnonceRepositoy : CrudRepository<Annonce>
    {
        private stage_entrepriseContext context;

        public AnnonceRepositoy(stage_entrepriseContext context)
        {
            this.context = context;
        }

        public IQueryable<Annonce> Filter(Annonce model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Annonce> FindAll()
        {
            return this.context.Annonce;
        }

        public Annonce FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Annonce> Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Annonce Save(Annonce model)
        {
            throw new NotImplementedException();
        }

        public Annonce Update(Annonce model)
        {
            throw new NotImplementedException();
        }
    }
}
