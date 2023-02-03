namespace WebApi.Services
{
    public interface IBaseService<T>
    {
        void Add(T entity);
    }
}
