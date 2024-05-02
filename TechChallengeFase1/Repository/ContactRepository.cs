using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;

namespace TechChallengeFase1.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        public IList<Contact> ListEntities { get ; set ; }

        public ContactRepository()
        {
            this.ListEntities = new List<Contact>();
        }

        public Contact CreateEntity(Contact entidade)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> ToListEntities()
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Contact entidade)
        {
            throw new NotImplementedException();
        }
    }
}
