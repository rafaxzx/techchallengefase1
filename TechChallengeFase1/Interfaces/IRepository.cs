using TechChallengeFase1.Entities;

namespace TechChallengeFase1.Interfaces
{
    //Criamos uma interface para nosso CRUD
    public interface IRepository<T>
    {
        //Create
        public void CreateEntity(T entidade);
        //Read
        public IEnumerable<T> ToListEntities();
        //Update
        public void UpdateEntity(int id, T entidade);
        //Delete
        public void DeleteEntity(int Id);
        public T GetById(int Id);
    }
}
