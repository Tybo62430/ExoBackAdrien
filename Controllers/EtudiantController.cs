using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoBackAdrien.Controllers
{
    using Domaine;

    [Route("etudiants")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {  
        private stage_entrepriseContext context;

        public EtudiantController(stage_entrepriseContext context)
        {
            this.context = context;
        }   

        [HttpGet]
        [Route("")]
        public IEnumerable<Etudiant> FindAll()
        {
            return this.context.Etudiant.Select(etudiant => etudiant);         
        }

        [HttpPost]
        [Route("")]
        public Etudiant Save([FromBody] Etudiant etudiant)
        {
            this.context.Add(etudiant);
            this.context.SaveChanges();

            return etudiant;
        }
    }
}