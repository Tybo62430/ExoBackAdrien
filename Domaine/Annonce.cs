using System;
using System.Collections.Generic;

namespace ExoBackAdrien.Domaine
{
    public partial class Annonce
    {
        public Annonce()
        {
            Contact = new HashSet<Contact>();
            Convention = new HashSet<Convention>();
        }

        public int Id { get; set; }
        public int EntrepriseId { get; set; }
        public string Sujet { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Remuneration { get; set; }

        public virtual Entreprise Entreprise { get; set; }
        public virtual ICollection<Contact> Contact { get; set; }
        public virtual ICollection<Convention> Convention { get; set; }
    }
}
