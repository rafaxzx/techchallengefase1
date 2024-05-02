using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;

namespace TechChallengeFase1.Repository
{
    public class DDDRepository : IRepository<DDD>
    {
        public IList<DDD> ListEntities { get ; set ; }

        public DDDRepository()
        {
            this.ListEntities = new List<DDD>();
        }

        public DDD CreateEntity(DDD entidade)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DDD> ToListEntities()
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(DDD entidade)
        {
            throw new NotImplementedException();
        }
    }
}
