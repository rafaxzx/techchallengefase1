using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;

namespace TechChallengeFase1.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            ArgumentNullException.ThrowIfNull(nameof(context));
            _context = context;
        }

        public void CreateEntity(Contact entidade)
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

        public void UpdateEntity(int id, Contact entidade)
        {
            throw new NotImplementedException();
        }
    }
}
