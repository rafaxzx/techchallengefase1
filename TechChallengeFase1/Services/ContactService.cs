using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;

namespace TechChallengeFase1.Services
{
    public class ContactService : IService<Contact>
    {
        private readonly IRepository<Contact> _repository;
        public ContactService(IRepository<Contact> contactRepository)
        {
            _repository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
        }
        public void Create(Contact contact)
        {
            ArgumentNullException.ThrowIfNull(contact, nameof(contact));
            _repository.CreateEntity(contact);
        }

        public void Delete(int id)
        {
            _repository.DeleteEntity(id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _repository.ToListEntities();
        }

        public Contact GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(int id, Contact contact)
        {
            _repository.UpdateEntity(id, contact);
        }
    }
}
