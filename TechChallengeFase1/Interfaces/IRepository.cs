using TechChallengeFase1.Entities;

namespace TechChallengeFase1.Interfaces
{
    //Criamos uma interface para nosso CRUD
    public interface IRepository<T>
    {
        IList<T> ListEntities {  get; set; }

        //Create
        public T CreateEntity(T entidade);
        //Read
        public IEnumerable<T> ToListEntities();
        //Update
        public void UpdateEntity(T entidade);
        //Delete
        public void DeleteEntity(int Id);
    }
}
