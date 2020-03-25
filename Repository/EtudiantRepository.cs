using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class EtudiantRepository : CrudSQLRepository<Etudiant>
    {
        public EtudiantRepository(stage_entrepriseContext context): base(context)
        {

        }

    }
}
