using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBackAdrien.Repository
{
    using ExoBackAdrien.Domaine;
    public class ContactRepository : CrudRepository<Contact>
    {
        private stage_entrepriseContext context;
        public ContactRepository(stage_entrepriseContext context)
        {
            this.context = context;
        }

        public IQueryable<Contact> Filter(Contact model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> FindAll()
        {
            return this.context.Contact;
        }

        public Contact FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public Contact Save(Contact model)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact model)
        {
            throw new NotImplementedException();
        }
    }
}
