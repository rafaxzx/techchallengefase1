namespace TechChallengeFase1.Interfaces
{
    public interface IService<T>
    {
        //Create
        public void Create(T entity);
        //Read all
        public IEnumerable<T> GetAll();
        //Read by Id
        public T GetById(int id);
        // Update
        public void Update(int id, T entity);
        // Delete
        public void Delete(int id);
    }
}
