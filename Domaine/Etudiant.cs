using System;
using System.Collections.Generic;

namespace ExoBackAdrien.Domaine
{
    public partial class Etudiant
    {
        public Etudiant()
        {
            Contact = new HashSet<Contact>();
            Convention = new HashSet<Convention>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<Convention> Convention { get; set; }
    }
}
