using System;
using System.Collections.Generic;

namespace ExoBackAdrien.Domaine
{
    public partial class Visite
    {
        public int Id { get; set; }
        public int EnseignantId { get; set; }
        public int EntrepriseId { get; set; }

        public virtual Enseignant Enseignant { get; set; }
        public virtual Entreprise Entreprise { get; set; }
    }
}
