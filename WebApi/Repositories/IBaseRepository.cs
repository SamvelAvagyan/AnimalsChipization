namespace WebApi.Repositories
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        void Add(T entity);
    }
}
