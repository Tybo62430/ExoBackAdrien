using System;
using System.Collections.Generic;

namespace ExoBackAdrien.Domaine
{
    public partial class Enseignant
    {
        public Enseignant()
        {
            Visite = new HashSet<Visite>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Visite> Visite { get; set; }
    }
}
