using System;
using System.Collections.Generic;

namespace ExoBackAdrien.Domaine
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int EntrepriseId { get; set; }
        public int EtudiantId { get; set; }
        public DateTime? Date { get; set; }
        public int AnnonceId { get; set; }

        public virtual Annonce Annonce { get; set; }
        public virtual Entreprise Entreprise { get; set; }
        public virtual Etudiant Etudiant { get; set; }
    }
}
