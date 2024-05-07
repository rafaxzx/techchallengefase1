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

        public void CreateEntity(Contact contact)
        {
            var idDDD = contact.DDDId;
            contact.Ddd = _context.DDD.Find(idDDD);
            contact.Ddd.Contacts = [];
            _context.Add(contact);
            _context.SaveChanges();
        }

        public void DeleteEntity(int Id)
        {
            _context.Remove(_context.Contact.Find(Id));
            _context.SaveChanges();
        }

        public IEnumerable<Contact> ToListEntities()
        {
            var listOfContacts = _context.Contact.ToList();
            foreach (var contact in listOfContacts)
            {
                contact.Ddd = _context.DDD.Find(contact.DDDId);
                contact.Ddd.Contacts = [];
            }
            return listOfContacts;
        }

        public void UpdateEntity(int id, Contact contact)
        {
            var contactToUpdate = _context.Contact.Find(id);
            if (contactToUpdate != null)
            {
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.PhoneNumber = contact.PhoneNumber;
                contactToUpdate.DDDId = contact.DDDId;

                _context.Update(contactToUpdate);
                _context.SaveChanges();
            }
        }
        public Contact GetByIdEntity(int id)
        {
            return _context.Contact.Find(id);
        }
    }
}
