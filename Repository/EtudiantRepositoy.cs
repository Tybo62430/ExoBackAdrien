using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class EtudiantRepositoy : CrudRepository<Etudiant>
    {
        private stage_entrepriseContext context;

        public EtudiantRepositoy(stage_entrepriseContext context)
        {
            this.context = context;
        }

        public IQueryable<Etudiant> Filter(Etudiant model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Etudiant> FindAll()
        {  
             return this.context.Etudiant;
        }

        public Etudiant FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Etudiant> Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Etudiant Save(Etudiant model)
        {
            throw new NotImplementedException();
        }

        public Etudiant Update(Etudiant model)
        {
            throw new NotImplementedException();
        }
    }
}
