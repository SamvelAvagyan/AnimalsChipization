namespace WebApi.Repositories
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);
    }
}
