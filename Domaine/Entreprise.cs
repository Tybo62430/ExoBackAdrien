using System;
using System.Collections.Generic;

namespace ExoBackAdrien.Domaine
{
    public partial class Entreprise
    {
        public Entreprise()
        {
            Annonce = new HashSet<Annonce>();
            Contact = new HashSet<Contact>();
            Visite = new HashSet<Visite>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Annonce> Annonce { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<Visite> Visite { get; set; }
    }
}
