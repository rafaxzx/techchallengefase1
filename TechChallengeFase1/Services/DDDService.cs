using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;
using TechChallengeFase1.Repository;

namespace TechChallengeFase1.Services
{
    public class DDDService : IService<DDD>
    {
        private readonly IRepository<DDD> _repository;

        public DDDService(IRepository<DDD> dddRepository)
        {
            _repository = dddRepository ?? throw new ArgumentNullException(nameof(dddRepository));
        }

        public void Create(DDD ddd)
        {
            ArgumentNullException.ThrowIfNull(ddd, nameof(ddd));

            _repository.CreateEntity(ddd);
        }

        public void Delete(int id)
        {
            _repository.DeleteEntity(id);
        }

        public IEnumerable<DDD> GetAll()
        {
           var ddds = _repository.ToListEntities();
            foreach (var ddd in ddds) 
            {
                ddd.Contacts = [];
            }
            return ddds;
        }

        public DDD GetById(int id)
        {
            var ddd = _repository.GetByIdEntity(id);
            ddd.Contacts = [];
            return ddd;
        }

        public void Update(int id, DDD ddd)
        {
            _repository.UpdateEntity(id, ddd);
        }
    }
}
