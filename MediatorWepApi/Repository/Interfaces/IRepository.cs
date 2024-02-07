namespace MediatorWepApi.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);

        Task<T> Insert(T entity);
    }
}
