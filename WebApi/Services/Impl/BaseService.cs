using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services.Impl
{
    public class BaseService<T> : IBaseService<T>
        where T: BaseModel
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Add(T entity)
        {
            _baseRepository.Add(entity);
        }
    }
}
