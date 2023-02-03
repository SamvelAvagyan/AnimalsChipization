using WebApi.Models;

namespace WebApi.Repositories.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseModel
    {
        private List<T> _entities = new List<T>();

        public void Add(T model)
        {
            _entities.Add(model);
        }
    }
}
