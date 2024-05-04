using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;

namespace TechChallengeFase1.Repository
{
    public class DDDRepository : IRepository<DDD>
    {
        private readonly ApplicationDbContext _context;

        public DDDRepository(ApplicationDbContext context)
        {
            ArgumentNullException.ThrowIfNull(nameof(context));
            _context = context;
        }

        public void CreateEntity(DDD ddd)
        {
            _context.Add(ddd);
            _context.SaveChanges();
        }

        public void DeleteEntity(int Id)
        {
            _context.Remove(_context.DDD.Find(Id));
            _context.SaveChanges();
        }

        public IEnumerable<DDD> ToListEntities()
        {
            return _context.DDD.ToList();
        }

        public void UpdateEntity(int id, DDD ddd)
        {
            var dddToUpdate = _context.DDD.Find(id);
            if (dddToUpdate != null)
            {
                dddToUpdate.Number = ddd.Number;
                dddToUpdate.Regiao = ddd.Regiao;

                _context.Update(dddToUpdate);
                _context.SaveChanges();
            }
        }
        public DDD GetById(int id) {

            return _context.DDD.Find(id);
        }
    }
}
