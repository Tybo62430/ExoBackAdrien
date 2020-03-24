using System;
using System.Collections.Generic;

namespace ExoBackAdrien.Domaine
{
    public partial class Convention
    {
        public int Id { get; set; }
        public int AnnonceId { get; set; }
        public int EtudiantId { get; set; }

        public virtual Annonce Annonce { get; set; }
        public virtual Etudiant Etudiant { get; set; }
    }
}
