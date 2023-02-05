namespace WebApi.Services
{
    public interface IBaseService<T>
    {
        IQueryable<T> GetAll();
        void Add(T entity);
    }
}
